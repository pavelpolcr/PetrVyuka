using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petr
{
    public class Budik
    {
         public int Hlasitost { get; protected set; }
         public string Jmeno { get; protected set; }
         public string Zvoneni { get; protected set; }

        public Budik()
        {
                Hlasitost = 1;
                Jmeno = "Budík";
                Zvoneni = "crr crr crr";
        }

        public void Zazvon()
        {
                Console.WriteLine(Jmeno + " zvoní:" + Zvoneni);
        }


        
    }
}
