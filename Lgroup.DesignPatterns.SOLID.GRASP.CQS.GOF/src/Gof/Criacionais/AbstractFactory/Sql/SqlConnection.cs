using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Sql
{
    public class SqlConnection : DbConection
    {
        public void Close()
        {
            Console.WriteLine("SQL - Fechada");
        }

        public void Open()
        {
            Console.WriteLine("SQL - Aberta");
        }
    }
}
