using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sor___Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> sor = new Queue<int>();
            sor.Enqueue(1); 
            sor.Enqueue(2);
            sor.Enqueue(3); 
            sor.Enqueue(4);
            while (sor.Count != 0)
            {
                Console.WriteLine(sor.Dequeue());
            }
            foreach (int item in sor)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
