using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list.refe__2022.XI._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> regilista = new List<int>() { 20, 31, 10 };
            List<int> ujlista = regilista;
            ujlista.Add(40);
            Console.Write("régilista tartalma: ");
            foreach (int item in regilista)
            {
                Console.Write(item + ", ");
            }
            Console.Write("\nújlista tartalma: ");
            foreach (int item in ujlista)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
