using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sorlista = new ArrayList();
            sorlista.Add("string"); sorlista.Add(7); sorlista.Add('c');
            foreach (var item in sorlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
