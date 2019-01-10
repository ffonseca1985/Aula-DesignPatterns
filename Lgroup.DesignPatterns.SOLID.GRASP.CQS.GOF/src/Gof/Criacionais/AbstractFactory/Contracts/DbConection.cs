namespace AbstractFactory.Contracts
{
    public interface DbConection
    {
        void Open();
        void Close();
    }
}
