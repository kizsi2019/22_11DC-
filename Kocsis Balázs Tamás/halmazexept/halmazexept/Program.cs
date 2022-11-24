using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazexept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8};
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4};
            alaphalmaz.ExceptWith(halmaz1);

            foreach (var item in alaphalmaz)
            {
                Console.Write("{0}, ", item);
            }
            Console.ReadKey();
        }
    }
}
