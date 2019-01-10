using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Oracle
{
    public class OracleCommand : DbCommand
    {
        public void ExecuteQuery(string query)
        {
            //a chamada...
            Console.Write($"Oracle: {query}");   
        }
    }
}
