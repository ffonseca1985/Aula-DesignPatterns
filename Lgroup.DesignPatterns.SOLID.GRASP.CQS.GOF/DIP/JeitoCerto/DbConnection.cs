using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.JeitoCerto
{
    public interface DbConnection
    {
        void Open();
        void Close();
    }
}
