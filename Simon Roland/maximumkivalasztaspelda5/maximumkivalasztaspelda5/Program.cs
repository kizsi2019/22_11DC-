﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumkivalasztaspelda5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("julius.txt");
            List<double> hőmérséklet = new List<double>();
            while (!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonyabb_i = 0;
            int legmagasabb_i = 0;
            for(int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsonyabb_i]) legalacsonyabb_i = i;
                if (hőmérséklet[i] > hőmérséklet[legmagasabb_i]) legmagasabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fok volt!",legalacsonyabb_i + 1, hőmérséklet[legalacsonyabb_i]);
            Console.WriteLine("A legmagasabb hőmérséklet {0}.-án {1} fok volt!", legmagasabb_i + 1, hőmérséklet[legmagasabb_i]);
            Console.ReadKey();
        }
    }
}