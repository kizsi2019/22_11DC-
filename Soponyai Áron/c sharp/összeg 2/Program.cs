using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace összeg_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("díszek.txt");
            List<int> lista = new List<int>();
            while (!sr.EndOfStream)
            {
                lista.Add(int.Parse(sr.ReadLine()));
            }
            sr.Close();
            int összeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                összeg += lista[i];
            }
            Console.WriteLine("összeg:" + összeg);
            Console.ReadKey();
        }
    }
}
