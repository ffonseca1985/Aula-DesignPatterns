using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.JeitoCerto
{
    public class ClientConnection
    {
        private DbConnection _dbConection;
        public ClientConnection(DbConnection dbConection)
        {
            _dbConection = dbConection;
        }
        public void Open()
        {
            _dbConection.Open();
        }

        public void Close()
        {
            _dbConection.Close();
        }
    }
}
