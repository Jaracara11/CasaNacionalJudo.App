using CasaNacionalJudo.Core;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

namespace CasaNacionalJudo.Repository
{
    public class MemberRepository
    {
        public static IEnumerable<Member> GetAllMembers()
        {
            var query = "SELECT * FROM members;";

            using var conn = new SqliteConnection(DbConnection.DbConn);

            var result = conn.Query<Member>(query);

            return result;
        }

        public static IEnumerable<Member> GetMemberByName(string memberName)
        {
            var query = $"SELECT * FROM members WHERE firstName OR lastName LIKE '%{memberName}%'";

            using var conn = new SqliteConnection(DbConnection.DbConn);

            var result = conn.Query<Member>(query);

            return result;
        }

        public static void AddMember(Member member)
        {
            var query = "INSERT INTO members (firstName, lastName, birthDate, bloodType, identification, address, phone1, phone2, email, belt, signUpDate, monthlyFee, anualFee) " +
                "VALUES (@firstName, @lastName, @birthDate, @bloodType, @identification, @address, @phone1, @phone2, @email, @belt, @signUpDate, @monthlyFee, @anualFee)";

            var parameters = new DynamicParameters();

            parameters.Add("firstName", member.FirstName, DbType.String);
            parameters.Add("lastName", member.LastName, DbType.String);
            parameters.Add("birthDate", member.BirthDate, DbType.String);
            parameters.Add("bloodType", member.BloodType, DbType.String);
            parameters.Add("identification", member.Identification, DbType.String);
            parameters.Add("address", member.Address, DbType.String);
            parameters.Add("phone1", member.Phone1, DbType.String);
            parameters.Add("phone2", member.Phone2, DbType.String);
            parameters.Add("email", member.Email, DbType.String);
            parameters.Add("belt", member.Belt, DbType.String);
            parameters.Add("signUpDate", member.SignUpDate, DbType.Date);
            parameters.Add("monthlyFee", member.MonthlyFee, DbType.Decimal);
            parameters.Add("anualFee", member.AnualFee, DbType.Decimal);

            using var conn = new SqliteConnection(DbConnection.DbConn);

            conn.Execute(query, parameters);
        }

        public static void UpdateMember(Member member)
        {
            var query = "UPDATE members SET firstName= @firstName, lastName= @lastName, birthDate= @birthDate, bloodType= @bloodType, identification= @identification, address= @address, phone1= @phone1, phone2= @phone2, email= @email, belt= @belt, monthlyFee= @monthlyFee, anualFee= @anualFee " +
                "WHERE memberId= @memberId";

            var parameters = new DynamicParameters();

            parameters.Add("memberId", member.MemberId, DbType.Int32);
            parameters.Add("firstName", member.FirstName, DbType.String);
            parameters.Add("lastName", member.LastName, DbType.String);
            parameters.Add("birthDate", member.BirthDate, DbType.String);
            parameters.Add("bloodType", member.BloodType, DbType.String);
            parameters.Add("identification", member.Identification, DbType.String);
            parameters.Add("address", member.Address, DbType.String);
            parameters.Add("phone1", member.Phone1, DbType.String);
            parameters.Add("phone2", member.Phone2, DbType.String);
            parameters.Add("email", member.Email, DbType.String);
            parameters.Add("belt", member.Belt, DbType.String);
            parameters.Add("monthlyFee", member.MonthlyFee, DbType.Decimal);
            parameters.Add("anualFee", member.AnualFee, DbType.Decimal);

            using var conn = new SqliteConnection(DbConnection.DbConn);

            conn.Execute(query, parameters);
        }
    }
}
