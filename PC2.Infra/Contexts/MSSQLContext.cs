using PC2.Infra.Infra;
using System.Data;
using System.Data.SqlClient;

namespace PC2.Infra.Contexts
{
    public class MSSQLContext : IDB
    {
        SqlConnection connection;
        string stringConnection;

        public MSSQLContext(IDBConfiguration db)
        {
            stringConnection = db.connectionString;
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
