using AbstractFactory.Contracts;

namespace AbstractFactory.Sql
{
    public class SqlFactory : DbFactory
    {
        public DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
        public DbConection CreateConection()
        {
            return new SqlConnection();
        }
    }
}
