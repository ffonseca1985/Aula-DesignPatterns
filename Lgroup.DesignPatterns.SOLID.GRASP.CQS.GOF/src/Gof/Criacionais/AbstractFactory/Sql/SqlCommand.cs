using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sql
{
    class SqlCommand : DbCommand
    {
        public void ExecuteQuery(string query)
        {
            //a chamada...
            Console.Write($"SQL: {query}");
        }
    }
}
