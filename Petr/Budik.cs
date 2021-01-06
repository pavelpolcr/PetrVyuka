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

        public event EventHandler<ParametryUdalosti> Zvoneni;


        public Budik()
        {
                Hlasitost = 1;
                Jmeno = "Budík";
               
        }

        protected void PriZvoneni(int Hlasitost)
        {
            if (Zvoneni != null)
                Zvoneni(this, new ParametryUdalosti(Hlasitost));
        }

        public void Zazvon()
        {
            Console.WriteLine(Jmeno + " zvoní:");
            
        }


        
    }
}
