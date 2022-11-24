using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szotar_containskey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> szótár = new Dictionary<string, string>(){{"piros", "red"}, {"kék", "blue"} };
            foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }
            if (szótár.ContainsKey("green")) Console.WriteLine("Van green");
            else Console.WriteLine("Nincs zöld");
            Console.ReadKey();
        }
    }
}
