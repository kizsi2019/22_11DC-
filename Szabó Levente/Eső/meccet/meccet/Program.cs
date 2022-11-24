using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meccet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaz.SymmetricExceptWith(halmaz1);

        }
    }
}
