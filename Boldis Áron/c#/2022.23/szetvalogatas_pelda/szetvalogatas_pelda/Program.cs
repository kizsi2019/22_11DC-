using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szetvalogatas_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("szamok.txt");
            int[] szamokT = new int[30];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
                j = j+ 1;
            }
            sr.Close();
            int[] negyzetszamokT = new int[30];
            int[] oszhato3szamokT = new int[30];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i]; negyzet_i++;
                }
                if (szamokT[i] % 3 == 0)
                {
                    oszhato3szamokT[osz3_i] = szamokT[i];
                    osz3_i++;
                }
            }
            Console.WriteLine("Hárommal osztahtö: ");
            foreach(int i in oszhato3szamokT)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Negyzetszamok: ");
            foreach (int i in negyzetszamokT)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
