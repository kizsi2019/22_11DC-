﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Állatok(Kutya, Tigris, Zsiráf, Oroszlán);
        static void Main(string[] args)
        {
            Állatok állat = Állatok.Tigtis;
            Console.WriteLine(állatok);
            Console.WriteLine("Az 1-esnek megfelelő a(z): {0}", (Állatok)1);
            Console.WriteLine("A(z) {0}-nak megfelelő szám a(z) {1}" Állatok.Oroszlán, (int)Állatok.Oroszlán);
            Console.ReadKey();
        }
    }
}
