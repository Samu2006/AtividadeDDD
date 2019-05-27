using PC2.Infra.Infra;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace PC2.Infra.Contexts
{
    public class SQLLITEContext : IDB
    {
      


        SQLiteConnection liteConnection;
        private string stringConnection { get => @"Data Source = C:\Users\55639\Desktop\PC2\PC2.Infra\Database\PC2.db; Version = 3;"; }
        public SQLLITEContext()
        {
           
        }

        public void Dispose()
        {
            liteConnection.Close();
            liteConnection.Dispose();
        }

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(stringConnection);
        }
    }
}
