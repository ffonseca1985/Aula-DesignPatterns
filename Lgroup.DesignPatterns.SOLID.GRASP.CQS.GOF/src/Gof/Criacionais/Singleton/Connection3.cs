using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Connection3
    {
        private Connection3() { }
        private class ConnectionIntern
        {
            public static readonly Connection3 Conection = new Connection3();
        }

        public static Connection3 GetInstance()
        {
            return ConnectionIntern.Conection;
        }
    }
}
