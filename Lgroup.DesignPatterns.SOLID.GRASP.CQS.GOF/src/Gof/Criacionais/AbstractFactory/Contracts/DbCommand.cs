namespace AbstractFactory.Contracts
{
    public interface DbCommand
    {
        void ExecuteQuery(string query);
    }
}
