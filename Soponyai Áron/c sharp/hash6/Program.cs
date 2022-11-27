using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaz.IntersectWith(halmaz1);
            foreach (var item in halmaz1)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
