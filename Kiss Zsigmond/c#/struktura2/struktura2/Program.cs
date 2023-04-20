﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura2
{
    class Program
    {
        struct Diák
        {
            public string név; //<- erre mutat a this public
            int életkor; 
            public string lakhely; 
            public List<int> jegyei; 
            public Diák(string név, int k, string h) 
            { 
                this.név = név; 
                this.életkor = k; 
                this.lakhely = h; 
                this.jegyei = null; //^ mivel kötelező az összes adattagot beállítani ezért a jegyei null
            } 
            public void Kiír() 
            { 
                Console.WriteLine("Név: " + this.név); 
                Console.WriteLine("Életkor: " + this.életkor); 
                Console.WriteLine("Lakhely: " + this.lakhely); 
                Console.Write("Jegyei: "); 
                foreach (int item in this.jegyei) 
                { 
                    Console.Write(item + ", ");
                } 
                Console.WriteLine("\nA diák átlaga: " + Átlag()); 
            } 
            public double Átlag() 
            { 
                int összeg = 0; 
                foreach (int item in this.jegyei) 
                { 
                    összeg += item; 
                } 
                return összeg / (double) this.jegyei.Count; 
            } 
        }
            static void Main(string[] args)
        {
            Diák d = new Diák("András", 17, "Sopron"); 
            d.jegyei = new List<int>() { 4, 5, 3, 5, 5, 4 }; 
            Console.WriteLine("A diák adatai:"); 
            d.Kiír(); 
            Console.ReadKey();
        }
    }
}