using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtombmerettel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in RandT(10, 20, 30))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            }
            static int[] RandT(int Tmeret, int mettol, int meddig)
            {
                Random r = new Random();
                int[] visszaT = new int[Tmeret];
                for (int i = 0; i < visszaT.Length; i++)
                {
                    visszaT[i] = r.Next(mettol, meddig);
                }
                return visszaT;
            }
        }
    }







