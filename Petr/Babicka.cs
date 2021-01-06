using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petr
{
    class Babicka: Clovek
    {
        public Babicka()
        {
            Jmeno = "Babička";
        }

        public override void VzbudSe(object sender, ParametryUdalosti e)
        {
            if (e.Hlasitost >= 2)
                Console.WriteLine("Babička vstává");
        }
    }
}
