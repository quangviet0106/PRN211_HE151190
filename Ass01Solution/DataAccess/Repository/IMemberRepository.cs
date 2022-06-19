using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Enums;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Task<int> CreateMember(MemberObject member, CancellationToken cancellationToken = default);
        Task<int> DeleteMember(int id, CancellationToken cancellationToken = default);
        Task<int> UpdateMember(MemberObject member, CancellationToken cancellationToken = default);
        Task<MemberObject?> ViewMember(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<MemberObject>> ViewMembers(CancellationToken cancellationToken = default);
        Task<IEnumerable<MemberObject>> SearchMembers(string? keyword, SearchBy searchBy, CancellationToken cancellationToken = default);
    }
}
