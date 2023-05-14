using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazok___HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43 };
            Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
            halmaz.Add(17);
            Console.WriteLine("Hozzáadás után: " + halmaz.Count);
            Random r = new Random();
            HashSet<int> lottószámok = new HashSet<int>();
            while (lottószámok.Count < 5)
            {
                lottószámok.Add(r.Next(0, 91));
            }
            Console.WriteLine("A sorsolt lottószámok: ");
            foreach (int item in lottószámok)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
        
    }
}
