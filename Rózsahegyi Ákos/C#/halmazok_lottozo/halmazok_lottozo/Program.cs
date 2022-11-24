using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazok_lottozo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            HashSet<int> lottoszamok = new HashSet<int>();
            while (lottoszamok.Count < 5)
            {
                lottoszamok.Add(r.Next(0,91));
            }
            Console.WriteLine("A sorsolt lottószámok: ");
            foreach (int item in lottoszamok)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
