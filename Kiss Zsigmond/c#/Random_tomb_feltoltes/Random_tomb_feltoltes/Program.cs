﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Random_tomb_feltoltes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] veletlen_szamok = new int[5];
            RandTomb(veletlen_szamok, 1, 91);
            foreach (int item in veletlen_szamok)
            { 
                Console.WriteLine(item); 
            }
             Console.ReadKey();
            }
        static void RandTomb(int[] tomb, int mettol, int meddig) 
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++) 
            { 
                tomb[i] = r.Next(mettol, meddig); 
            } 
        }
    }
}
