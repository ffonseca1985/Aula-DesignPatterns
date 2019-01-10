using System;

namespace DIP.JeitoCerto
{
    public class SqlConnection : DbConnection
    {
        public void Close()
        {
            Console.WriteLine("SQL - conexão Fechada");
        }

        public void Open()
        {
            Console.WriteLine("SQL -conexão Aberta");
        }
    }
}
