using CasaNacionalJudo.Core;
using Dapper;
using Microsoft.Data.Sqlite;

namespace CasaNacionalJudo.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            var query = "SELECT * FROM members;";

            using var conn = new SqliteConnection(DbConnection.DbConn);

            var result = await conn.QueryAsync<Member>(query);

            return result.ToList();
        }
    }
}
