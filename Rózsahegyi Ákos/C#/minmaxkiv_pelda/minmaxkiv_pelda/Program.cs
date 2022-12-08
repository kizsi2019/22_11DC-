using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmaxkiv_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\minmaxkiv_pelda\minmaxkiv_pelda\bin\Debug\julius.txt");
            List<double> homerseklet = new List<double>();
            while (!sr.EndOfStream)
            {
                homerseklet.Add(double.Parse(sr.ReadLine()));
            }
            // Min/max kiválasztás
            int legalacsonyabb_i = 0;
            int legnagyobb_i = 0;
            for (int i = 0; i < homerseklet.Count; i++)
            {
                if (homerseklet[i] < homerseklet[legalacsonyabb_i]) legalacsonyabb_i = i;
                if (homerseklet[i] > homerseklet[legnagyobb_i]) legnagyobb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fok volt!", legalacsonyabb_i + 1,
            homerseklet[legalacsonyabb_i]);
            Console.WriteLine("A legnagyobb hőmérséklet {0}.-án {1} fok volt!", legnagyobb_i + 1,
            homerseklet[legnagyobb_i]);
            Console.ReadKey();
        }
    }
}
