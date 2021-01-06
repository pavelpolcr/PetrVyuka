using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petr
{
    class Program
    {
        static void Main(string[] args)
        {
            Budik budik = new Budik();
            Digibudik digi = new Digibudik();
            Clovek clovek = new Clovek();
            Babicka babicka = new Babicka();

            budik.Zvoneni += clovek.VzbudSe;
            budik.Zvoneni += babicka.VzbudSe;

            digi.Zvoneni += clovek.VzbudSe;
            digi.Zvoneni += babicka.VzbudSe;

            budik.Zazvon();
            digi.Zazvon();
            
            Console.ReadKey();

        }
    }
}
