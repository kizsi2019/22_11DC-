using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace eldontes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0,21);

            }
            int j = 0;
            while (j < randT.Length && randT[j]<=15)
            {
                j++;
            }
            for (int i =0;i <randT.Length;i++)
            {
                Console.WriteLine(randT[i]);
            }
            if (j < randT.Length) Console.WriteLine(" 15 nél nagyobb szám");
            else Console.WriteLine(("nincs 15 nél nagyobb szám");
        }
    }
}
