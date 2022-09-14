using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elol_tesztelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meddigirjamki a páros számokat?");
            int meddig = int.Parse(Console.ReadLine());
            int paros_szam = 0;
            while (paros_szam < meddig);
            {
                paros_szam += 2;
                Console.Write(paros_szam+ ", ");
            }
            Console.ReadLine();
        }
    }
}
