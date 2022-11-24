using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halamaz_unio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int>unio=new HashSet<int>(){10,32,4,8};
            HashSet<int> halmaz1 = new HashSet<int>() { 10, 32, 4, 8 };
            unio.UnionWith(halmaz1);
            {
                Console.WriteLine();
            }

        }
    }
}
