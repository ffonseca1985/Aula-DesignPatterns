using AbstractFactory.Contracts;

namespace AbstractFactory.Oracle
{
    public class OracleFactory : DbFactory
    {
        public DbCommand CreateCommand()
        {
            return new OracleCommand();
            
        }

        public DbConection CreateConection()
        {
            return new OracleConection();
        }
    }
}
