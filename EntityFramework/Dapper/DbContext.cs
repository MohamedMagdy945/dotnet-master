

using Microsoft.Data.SqlClient;

namespace Dapper_DotNet
{
    public class DbContext
    {
        private string connectionString =
       "Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
