using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            HashSet<int> lottószámok = new HashSet<int>();
            {
                lottószámok.Add(r.Next(0, 91));
            }
            Console.WriteLine("A sorsolt lottószámok: ");
            foreach (int item in lottószámok)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
