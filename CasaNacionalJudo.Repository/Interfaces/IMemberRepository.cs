using CasaNacionalJudo.Core;

namespace CasaNacionalJudo.Repository
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetAllMembers();
    }
}