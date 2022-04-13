using CasaNacionalJudo.Core;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

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

        public void AddMember(Member member)
        {
            var query = "INSERT INTO members (firstName, lastName, birthDate, bloodType, identification, address, phone, email, monthlyFee, anualFee, totalAmountDue) " +
                "VALUES (@firstName, @lastName, @birthDate, @bloodType, @identification, @address, @phone, @email, @monthlyFee, @anualFee, @totalAmountDue)";

            var parameters = new DynamicParameters();
            parameters.Add("firstName", member.FirstName, DbType.String);
            parameters.Add("lastName", member.FirstName, DbType.String);
            parameters.Add("birthDate", member.FirstName, DbType.DateTime);
            parameters.Add("bloodType", member.FirstName, DbType.String);
            parameters.Add("identification", member.FirstName, DbType.String);
            parameters.Add("address", member.FirstName, DbType.String);
            parameters.Add("phone", member.FirstName, DbType.String);
            parameters.Add("email", member.FirstName, DbType.String);
            parameters.Add("monthlyFee", member.FirstName, DbType.Decimal);
            parameters.Add("anualFee", member.FirstName, DbType.Decimal);
            parameters.Add("totalAmountDue", member.FirstName, DbType.Decimal);

            using var conn = new SqliteConnection(DbConnection.DbConn);

            conn.Execute(query, parameters);
        }
    }
}
