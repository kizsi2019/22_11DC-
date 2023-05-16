using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_tryparse
{
    class Program
    {
        enum Színek { piros, narancs, zöld, kék, barna, szürke, fekete, fehér };
        static void Main(string[] args)
        {
            Színek szín;
            Console.Write("Adj meg egy színt! ");
            if (Enum.TryParse(Console.ReadLine(), out szín)) 
                Console.WriteLine("Sikeres konvertálás " + szín); 
            else 
                Console.WriteLine("Sikertelen konvertálás"); 
            Console.ReadKey();

        }
    }
}
