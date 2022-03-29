using CasaNacionalJudo.Core;
using Dapper;
using Microsoft.Data.Sqlite;

namespace CasaNacionalJudo.Repository
{
    public class MemberRepository
    {
        public IEnumerable<Member> GetAllMembers()
        {
            var query = "SELECT * FROM members;";

            using var conn = new SqliteConnection(DbConnection.DbConn);

            var result = conn.Query<Member>(query);

            return result.ToList();
        }
    }
}
