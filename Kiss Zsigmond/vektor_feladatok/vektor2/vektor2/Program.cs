﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] bevetel = new int[365];
            int[] kiadas = new int[365];
            int[] haszon = new int[365];
            int legjobb = 0;
            for ( int i = 1; i < bevetel.Length; i++)
            {
                bevetel[i] = r.Next(4000, 12000);
                kiadas[i] = r.Next(2000, 4000);
                haszon[i] = bevetel[i]-kiadas[i];
                if (haszon[i] > legjobb)
                {
                    legjobb = haszon[i];
                }
            }
            Console.WriteLine("A legjobb napi haszon: " + legjobb);
            Console.ReadKey();
            

        }
    }
}
