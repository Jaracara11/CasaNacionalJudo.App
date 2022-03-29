using CasaNacionalJudo.Core;

namespace CasaNacionalJudo.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAllMembers();
    }
}