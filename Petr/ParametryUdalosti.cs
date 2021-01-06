using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petr
{
    public class ParametryUdalosti : EventArgs
    {
        public int Hlasitost { get; private set; }
        public ParametryUdalosti(int hlasitost)
        {
            Hlasitost = hlasitost;
        }
    }
}
