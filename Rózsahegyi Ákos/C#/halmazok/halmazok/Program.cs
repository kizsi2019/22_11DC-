using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> halmaz = new HashSet<int>() {17, 10, 20, 43};
            Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
            halmaz.Add(17);
            Console.WriteLine("Hozzáadás után: " + halmaz.Count);
            Console.ReadKey();
        }
    }
}
