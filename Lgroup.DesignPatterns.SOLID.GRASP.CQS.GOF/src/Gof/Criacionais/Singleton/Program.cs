using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn1 = Connection.GetInstance();
            var conn2 = Connection.GetInstance();

            if (conn1.GetType().IsAssignableFrom(conn2.GetType()))
            {
                var a = 1;
            }

            if (conn1.GetHashCode().Equals(conn2.GetHashCode())){
                var b = 2;
            }

            if (conn1.Equals(conn2))
            {
                var c = 2;
            }

            var conn3 = Connection2.Conection;
            var conn4 = Connection2.Conection;

            var conn5 = Connection3.GetInstance();

        }
    }
}
