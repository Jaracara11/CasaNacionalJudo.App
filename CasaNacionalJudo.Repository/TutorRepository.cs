using CasaNacionalJudo.Core;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

namespace CasaNacionalJudo.Repository
{
    public class TutorRepository
    {
        public void AddTutor(Tutor tutor)
        {
            var query = "INSERT INTO tutors (firstName, lastName, identification, address, phone1, phone2, email) " +
                "VALUES (@firstName, @lastName, @identification, @address, @phone1, @phone2, @email)";

            var parameters = new DynamicParameters();

            parameters.Add("firstName", tutor.FirstName, DbType.String);
            parameters.Add("lastName", tutor.LastName, DbType.String);
            parameters.Add("identification", tutor.Identification, DbType.String);
            parameters.Add("address", tutor.Address, DbType.String);
            parameters.Add("phone1", tutor.Phone1, DbType.String);
            parameters.Add("phone2", tutor.Phone2, DbType.String);
            parameters.Add("email", tutor.Email, DbType.String);

            using var conn = new SqliteConnection(DbConnection.DbConn);

            conn.Execute(query, parameters);
        }
    }
}
