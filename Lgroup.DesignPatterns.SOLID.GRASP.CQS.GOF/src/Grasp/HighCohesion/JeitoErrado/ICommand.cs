namespace HighCohesion.JeitoErrado
{
    public interface ICommand
    {
        void Execute(IConnection conection, string query);
    }
}
