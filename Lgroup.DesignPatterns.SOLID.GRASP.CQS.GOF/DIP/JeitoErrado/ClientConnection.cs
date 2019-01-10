using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DIP.JeitoErrado
{
    //Este jeito é um jeito errado
    //Por varios motivos
    //1- Faz mais do que precisa
    //2- Se quisermos colocar um novo provider teremos que modificar a classe
    //3- Não estamos usando interface, inversão de dependÊncia (DIP)
    public class ClientConnection
    {
        public void AbrirSQl()
        {
            new SqlConnection().Open();
        }

        public void FecharSQL()
        {
            new SqlConnection().Close();
        }

        public void AbrirOracle()
        {
            new OleDbConnection().Open();
        }

        public void FecharOracle()
        {
            new OleDbConnection().Close();
        }
    }
}
