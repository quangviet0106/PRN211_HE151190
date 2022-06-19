using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Helpers
{
    public class PasswordHasher : IPasswordHasher
    {
        public bool VerifyPassword(string rawPassword, string encryptedPassword)
        {
            return rawPassword.Equals(encryptedPassword);
        }
    }
}
