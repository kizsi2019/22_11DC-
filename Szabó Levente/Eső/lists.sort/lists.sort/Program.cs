using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists.sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "banán", "alma", "körte", "narancs"};
            list.Sort();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
