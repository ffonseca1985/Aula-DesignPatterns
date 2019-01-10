using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEMPRE PROGRAME PARA INTERFACE
            //NUNCA PROGRAME COM CLASSES CONCRETAS
            var sql = new JeitoCerto.SqlConnection();
            var oracle = new JeitoCerto.OracleConnection();

            var clientSql = new JeitoCerto.ClientConnection(sql);
            var clientOracle = new JeitoCerto.ClientConnection(oracle);

            clientSql.Open();
            clientSql.Close();

            clientOracle.Open();
            clientOracle.Close();
        }
    }
}
