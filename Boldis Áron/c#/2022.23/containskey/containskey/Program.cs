using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containskey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> szotar = new Dictionary<string, string>() { { "piros", "red" }, { "kék", "blue" } };
            foreach (KeyValuePair<string, string> item in szotar)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }
            if (szotar.ContainsValue("green")) Console.WriteLine("Van zöld");
            else Console.WriteLine("Nincs zöld");
            Console.ReadKey();
        }
    }
}
