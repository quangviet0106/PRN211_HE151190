using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessObject.Interfaces;

namespace BusinessObject.Services
{
    public class MemberService : IMemberService
    {
        public Task<int> CreateMember(MemberObject member, CancellationToken cancellationToken = default) => throw new NotImplementedException();
        public Task<int> DeleteMember(int id, CancellationToken cancellationToken = default) => throw new NotImplementedException();
        public Task<MemberObject> UpdateMember(MemberObject member, CancellationToken cancellationToken = default) => throw new NotImplementedException();
        public Task<MemberObject> ViewMember(int id, CancellationToken cancellationToken = default) => throw new NotImplementedException();
        public Task<ICollection<MemberObject>> ViewMembers(string keyword, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }
}
