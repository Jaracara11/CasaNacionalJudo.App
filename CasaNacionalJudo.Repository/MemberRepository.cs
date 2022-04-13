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
            var query = "INSERT INTO members (firstName, lastName, birthDate, bloodType, identification, address, phone, email, belt, monthlyFee, anualFee, totalAmountDue) " +
                "VALUES (@firstName, @lastName, @birthDate, @bloodType, @identification, @address, @phone, @email, @belt, @monthlyFee, @anualFee, @totalAmountDue)";

            var parameters = new DynamicParameters();
            parameters.Add("firstName", member.FirstName, DbType.String);
            parameters.Add("lastName", member.LastName, DbType.String);
            parameters.Add("birthDate", member.BirthDate, DbType.String);
            parameters.Add("bloodType", member.BloodType, DbType.String);
            parameters.Add("identification", member.Identification, DbType.String);
            parameters.Add("address", member.Address, DbType.String);
            parameters.Add("phone", member.Phone, DbType.String);
            parameters.Add("email", member.Email, DbType.String);
            parameters.Add("belt", member.Belt, DbType.String);
            parameters.Add("monthlyFee", member.MonthlyFee, DbType.Decimal);
            parameters.Add("anualFee", member.AnualFee, DbType.Decimal);
            parameters.Add("totalAmountDue", member.TotalAmountDue, DbType.Decimal);

            using var conn = new SqliteConnection(DbConnection.DbConn);

            conn.Execute(query, parameters);
        }
    }
}
