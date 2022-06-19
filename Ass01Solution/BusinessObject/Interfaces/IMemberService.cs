using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessObject.Interfaces
{
    public interface IMemberService
    {
        Task<int> CreateMember(MemberObject member, CancellationToken cancellationToken = default);
        Task<int> DeleteMember(int id, CancellationToken cancellationToken = default);
        Task<MemberObject> UpdateMember(MemberObject member, CancellationToken cancellationToken = default);
        Task<MemberObject> ViewMember(int id, CancellationToken cancellationToken = default);
        Task<ICollection<MemberObject>> ViewMembers(string? keyword, CancellationToken cancellationToken = default);
    }
}
