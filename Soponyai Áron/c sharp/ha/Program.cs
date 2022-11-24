using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> szótár = new Dictionary<string, string>(){{"piros", "red"}, {"kék", "blue"}};
            foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {1}, értéke: {0}", item.Key, item.Value);
            }
            if (szótár.ContainsValue("Green")) Console.WriteLine("Van Green");
            else Console.WriteLine("Nincs Green");
            Console.ReadKey();
        }
    }
}
