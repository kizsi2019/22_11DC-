using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makiverem_monke_joke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> verem = new Stack<int>();
            verem.Push(1);
            verem.Push(2);
            verem.Push(3);
            verem.Push(4);
            foreach (int item in verem) {
                Console.WriteLine(item); }
            Console.ReadKey();
        }
    }
}
