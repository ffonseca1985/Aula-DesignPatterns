using AbstractFactory.Contracts;
using AbstractFactory.Oracle;
using AbstractFactory.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbFactory dbf = new OracleFactory();

            DbConection connection = dbf.CreateConection();
            DbCommand commnand = dbf.CreateCommand();

            connection.Open();
            commnand.ExecuteQuery("select * from ...");
            connection.Close();

        }
    }
}
