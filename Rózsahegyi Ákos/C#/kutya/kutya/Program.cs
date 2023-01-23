using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutya
{
    class kutya
        {
            public string nev;
            private int ehsegjelzo = 50;
            public void Etet(int etel)
            {
                ehsegjelzo -= etel;
            }
        }

        public void jatek()
        {
            if (ehsegjelzo <= 80)
            {
                ehsegjelzo += 50;
                Console.WriteLine("Játék...");
            }
            else Console.WriteLine("A kutya éhes, nem tudsz játszani vele!");
        }
    class Program
    {

        static void Main(string[] args)
        {
            kutya k = new kutya();
            k.jatek();
            k.jatek();
            Console.ReadKey();
        }
    }
}
