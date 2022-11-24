﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szotar.containkey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> szótár = new Dictionary<string, string>() { { "piros","red" }, {"kék", "blue" } };
            foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0}, érték: {1}", item.Key, item.Value);
            }
            if (szótár.ContainsKey("zöld")) Console.WriteLine("Van züld");
            else Console.WriteLine("Nincs züld");
            Console.ReadKey();
        }
    }
}
