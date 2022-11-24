using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossz_list__2022.XI._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>() { new List<int>(), new List<int> ()};
            lista.Add(new List<int>());
            lista[1].Add(14);
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; i++)
                {
                    Console.WriteLine(lista[i][j]);
                }
            }
            foreach (List<int> belsolista in lista)
            {
                foreach (int elem in belsolista)
                {
                    Console.WriteLine(elem);
                }
            }
            Console.ReadKey();
        }
    }
}
