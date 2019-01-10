using LSP.JeitoCerto;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailService();

            var pessoaFisica = new PessoaFisica();
            pessoaFisica.Cpf = "23123312312312";
            pessoaFisica.Nome = "ffonseca";

            emailService.EnviarEmail(pessoaFisica);
        }
    }
}
