using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace sudokuCLI
{
    class Feladvany
    {

        public string Kezdo { get; set; }
        public int Meret { get; private set; }  
        
        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }
        static void Kirajzol()
        {

        }
    }
    
    class program
    {
        static void Main(string[]args)
        {
            List<Feladvany>feladvanyok = new List<Feladvany>();
            string file = "feladvanyok.txt";
            StreamReader sr = new StreamReader(file);
            Feladvany fel;
            string sor;
            while(sr.EndOfStream==false)
            {
                sor = sr.ReadLine();
                fel = new Feladvany(sor);
                feladvanyok.Add(fel);



            }
            sr.Close();

            Console.WriteLine("3.Feladat:Beolvasva{0}Feladvány!",feladvanyok.Count);
            
            int meret = 0;
            do
            {
                Console.WriteLine("4. Feladat:Kérem a feladvány méretét[4..9]");
                meret = int.Parse(Console.ReadLine());
            } while (meret > 9 || meret < 4);

            int meretdb=0;
            foreach (var item in feladvanyok)
            {
                if(item.Meret==meret)
                    meretdb++;
            }

            Random rnd = new Random();
            int veletlen;

            do
            {
                veletlen = rnd.Next(0,feladvanyok.Count);
            }while (feladvanyok[veletlen].Meret!=meret);
            Console.WriteLine( "5. Feladat:A kiválaszott feladvány :\n{0}", feladvanyok[veletlen].Kezdo);
            
            
            Console.ReadLine();

        }
    }
}
