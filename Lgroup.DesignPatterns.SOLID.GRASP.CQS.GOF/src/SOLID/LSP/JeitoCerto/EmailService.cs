namespace LSP.JeitoCerto
{
    public class EmailService
    {
        public void EnviarEmail(Pessoa pessoa)
        {
            System.Console.WriteLine("Nome: " + pessoa.Nome);
            System.Console.WriteLine("Documento: " + pessoa.GetDocumento());
        }
    }
}