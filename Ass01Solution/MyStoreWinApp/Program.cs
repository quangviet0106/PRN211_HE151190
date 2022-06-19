using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BusinessObject.Helpers;
using BusinessObject.Interfaces;
using BusinessObject.Services;
using BusinessObject;
using DataAccess.Repository;
namespace MyStoreWinApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                
                var frmLogin = serviceProvider.GetRequiredService<frmLogin>();
                var config = serviceProvider.GetRequiredService<IConfiguration>();
                var x = config.GetSection("Members").Get<List<MemberObject>>();
                Console.WriteLine(x.First().Email);
                Application.Run(frmLogin);
                
            }

        }
        private static void ConfigureServices(IServiceCollection services)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = configurationBuilder.Build();
            services.AddSingleton<IConfiguration>(config);
           

            services.Configure<List<MemberObject>>(config.GetSection("Members"));
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IMemberRepository, MemberRepository>();
            services.AddSingleton<IMemberService, MemberService>();


            services.AddScoped<frmMemberManagement>();
            services.AddScoped<frmLogin>();
            services.AddScoped<frmMemberDetails>();
        }
    }
}
