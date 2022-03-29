using System.Configuration;

namespace CasaNacionalJudo.Repository
{
    public class DbConnection
    {
        private static readonly string _dbConn =
             ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;

        public static string DbConn { get => _dbConn; }
    }
}
