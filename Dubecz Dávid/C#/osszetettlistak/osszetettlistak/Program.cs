using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszetettlistak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>() { new List<int>(), new List<int>() };
            lista.Add(new List<int>());
            lista[1].Add(14);
            for (int i = 0; i < lista.Count; i++)
            { //körbejárása for-ral
                for (int j = 0; j < lista[i].Count; j++)
                {
                    Console.WriteLine(lista[i][j]);
                }
            }
            foreach (List<int> belsőlista in lista)
            { //körbejárása foreach ciklussal
                foreach (int elem in belsőlista)
                {
                    Console.WriteLine(elem);
                }
            }
            Console.ReadKey();
        }
    }
}
