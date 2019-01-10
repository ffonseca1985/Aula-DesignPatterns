using CQS.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplo client => FileStoreComplemento2
            var fileStore = new FileStoreComplemento2("CaminhoImaginario");
            var idFile = 32343323;

            var mensagem = string.Empty;
            bool result = fileStore.TryRead(idFile, out mensagem);

            if (result)
                Console.WriteLine(mensagem);

            //Exemplo client => FileStoreComplemento3
            var fileStore3 = new FileStoreComplemento3("CaminhoImaginario");
            var idFile3 = 32343323;

            var mensagem3 = string.Empty;
            var result3 = fileStore3.Read(idFile3).ToList();

            //Podemos usar linq ou expressões lambda para validar a mensagem
            //Analogo ao !IsEmpty do Java
            if (result3.Any(x => !string.IsNullOrEmpty(x)))
                Console.WriteLine(mensagem);
        }
    }
}
