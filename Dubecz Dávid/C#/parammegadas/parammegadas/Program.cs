using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parammegadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            c = crossadd(a, b);
            Console.WriteLine(\"\'a\' értéke:{0}\n\'b\' értéke:{1}\n\'c\' értéke:{2}\", a, b, c);
            Console.ReadKey();
        }
        static int crossadd(int szam1, int szam2)
        {
            szam1 = szam1 * 2; szam2 * 2;
            return szam1 + szam2
        }
    }
}
