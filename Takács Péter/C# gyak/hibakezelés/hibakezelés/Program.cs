using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hibakezelés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba -Nem sikerült átalakítani a bevitt karakterláncot!");
            }
            catch (OverflowException ofe)
            {
                 Console.WriteLine(ofe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ismeretlen hiba: "+e.Message);
            }
            Console.WriteLine("A kapott szám: "+ a);
            Console.ReadKey();
            //Console.WriteLine(a);
        }
    }
}
