using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Oracle
{
    public class OracleConection : DbConection
    {
        public void Close()
        {
            Console.WriteLine("Oracle - Fechada");
        }

        public void Open()
        {
            Console.WriteLine("Oracle - Aberta");
        }
    }
}
