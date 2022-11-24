using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz_unionwith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> unio = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            unio.UnionWith(halmaz1);
            foreach (var i in unio)
            {
                Console.Write("{0}, ", i);
            }
            Console.ReadKey();
        }
    }
}
