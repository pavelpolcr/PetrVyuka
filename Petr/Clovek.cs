using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petr
{
    class Clovek
    {
        public string Jmeno { get; protected set; }

        public Clovek()
        {
            Jmeno = "Člověk";
        }

        public virtual void VzbudSe(object sender, ParametryUdalosti e)
        {
            Console.WriteLine(Jmeno + " vstává");
        }
    }
}
