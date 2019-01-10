using System;

namespace DIP.JeitoCerto
{
    public class OracleConnection : DbConnection
    {
        public void Close()
        {
            Console.Write("Oracle - Conexão Fechada");
        }

        public void Open()
        {
            Console.Write("Oracle - Conexão Aberta");
        }
    }
}
