using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace outin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            Paros(10, out paros);
            Console.WriteLine(paros);
            Console.ReadKey();
        }

        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0) log = true;
            else log = false;
        }
    }
}
