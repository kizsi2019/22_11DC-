using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_ref_masolas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> régilista = new List<int>() { 20, 31, 10 }; 
            List<int> újlista = régilista; 
            újlista.Add(40); 
            Console.Write("régi lista tartalma: "); 
            foreach (int item in régilista) 
            { 
                Console.Write(item + ", "); 
            }
            Console.Write("\núj lista tartalma: "); 
            foreach (int item in újlista) 
            { 
                Console.Write(item + ", "); 
            }
            Console.ReadKey();
        }
    }
}
