﻿using System;
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
            
            digi.Zazvon();
            Console.ReadKey();

        }
    }
}
