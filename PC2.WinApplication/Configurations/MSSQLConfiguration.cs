using PC2.Infra.Infra;

namespace PC2.WinApplication.Configurations
{
    public class MSSQLConfiguration : IDBConfiguration
    {
        //public string connectionString => @"Server=DESKTOP-JTJTV94\SQLEXPRESS;Database=PC2;User Id=sa;Password=123;";
        // public string connectionString => @"Server=DESKTOP-PASKELU;Database=PC2;User Id=sa;Password=123;";
        public string connectionString => @"Server=SAMUCREED\SQLEXPRESS;Database=PC2;User Id=sa;Password=123;";
    }
}
