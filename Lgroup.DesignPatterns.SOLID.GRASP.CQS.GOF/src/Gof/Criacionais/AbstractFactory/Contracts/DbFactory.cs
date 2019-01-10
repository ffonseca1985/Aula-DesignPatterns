namespace AbstractFactory.Contracts
{
    public interface DbFactory
    {
        DbCommand CreateCommand();
        DbConection CreateConection();
    }
}
