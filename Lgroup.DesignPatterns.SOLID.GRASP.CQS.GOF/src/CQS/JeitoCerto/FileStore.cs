using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoCerto
{
    public class FileStore
    {
        public FileStore(string workingDirectory)
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
        
        public string Read(int id)
        {
            var path = GetPath(id);

            //Caso não exista o caminho podemos retornar vazio, para evitar de lançar uma
            //exceção
            if (File.Exists(path))
                return File.ReadAllText(path);

            return string.Empty;
        }
    }
}
