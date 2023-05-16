using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomopontok
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>(); 
            láncoltlista.AddLast("vár"); 
            láncoltlista.AddLast("kávé"); 
            láncoltlista.AddFirst("autó"); 
            LinkedListNode<string> csomópont = láncoltlista.First; 
            while (csomópont != null) 
            { 
                Console.WriteLine(csomópont.Value); 
                csomópont = csomópont.Next; 
            }
            Console.ReadKey();
        }
    }
}
