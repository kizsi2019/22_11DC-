using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maximum_kiválasztás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Július.txt");
            List<double> homerseklet = new List<double>();
            while (!sr.EndOfStream)
            {
                homerseklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonyabb_i = 0;
            int legmagasabb_i = 0;
            for (int i = 0;i < homerseklet.Count;i++)
            {
                if (homerseklet[i] < homerseklet[legalacsonyabb_i]) legalacsonyabb_i = i;
                if (homerseklet[i] < homerseklet[legmagasabb_i]) legmagasabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.- án {1} fok volt! ", legalacsonyabb_i + 1, homerseklet[legalacsonyabb_i]);
            Console.WriteLine("A legmagasabb hőmérséklet {0}.-án {1} fok volt!", legmagasabb_i + 1, homerseklet[legmagasabb_i]);
            Console.ReadKey();
        }
    }
}
