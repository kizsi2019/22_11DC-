using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazunion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> unió = new HashSet<int>() { 10, 32, 4, 8};
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4};
            unió.UnionWith(halmaz1);
            foreach (var item in unió)
            {
                Console.Write("{0}, ", item);
            }
            Console.ReadKey();
        }
    }
}
