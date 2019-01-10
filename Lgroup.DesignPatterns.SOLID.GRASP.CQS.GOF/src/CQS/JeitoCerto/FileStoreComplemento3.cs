using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoCerto
{
    class FileStoreComplemento3
    {
        public FileStoreComplemento3(string workingDirectory)
        {
            //Fazendo todas as validações para evitar erros!!
            if (string.IsNullOrWhiteSpace(workingDirectory))
                throw new ArgumentNullException("diretorio não informado");

            if (!Directory.Exists(workingDirectory))
                throw new ArgumentNullException("diretorio inexistente");

            this.WorkingDirectory = workingDirectory;
        }

        //Para evitar que algum usuario modifique esta propriedade
        //iremos bloquear o set.. (escrita)
        //semente poderemos modificar esta propriedade via construtor
        public string WorkingDirectory { get; private set; }
        public void Save(int id, string message)
        {
            var path = GetPath(id);
            File.WriteAllText(path, message);
        }

        public string GetPath(int id)
        {
            return Path.Combine(this.WorkingDirectory, id + ".txt");
        }

        //Qual a vantagem de retornar uma lista?
        //A Vantagem que podemos trabalhar com linq e expressões lambda
        public IEnumerable<string> Read(int id)
        {
            var path = GetPath(id);

            if (CanRead(id))
                return new List<string>() { File.ReadAllText(path) };
            else
                return new List<string>();
        }

        public bool CanRead(int id)
        {
            var path = GetPath(id);
            return File.Exists(path);
        }
    }
}
