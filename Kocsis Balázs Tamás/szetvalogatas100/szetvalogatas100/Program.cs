using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("számok.txt");
            int[] szamokT = new int[30];
            int j = 0;
            while (!sr.EndOfStream) 
            {
                szamokT[j] = int.Parse(sr.ReadLine());
                j = j + 1;
            }
            sr.Close();
            int[] negyzetszamokT = new int[30];
            int[] oszhato3szamokT = new int[30];
            int negyzet_i = 0, osz3_i= 0;
            for(int i = 0; i < szamokT.Length; i++)
            {
                if(szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamokT[negyzet_i] = szamokT[i];
                    negyzet_i++;
                }
                if(szamokT[i] % 3 == 0) 
                {
                    oszhato3szamokT[osz3_i] = szamokT[i];
                    osz3_i++;
                }
            }
            Console.WriteLine("Négyzetszámok: ");
            for (int i = 0; i < negyzetszamokT.Length; i++)
            {
                Console.WriteLine(negyzetszamokT[i]);
            }
            Console.WriteLine("3-al oszthatók: ");
            for (int i = 0; i < oszhato3szamokT.Length; i++)
            {
                Console.WriteLine(oszhato3szamokT[i]); 
            }
            Console.ReadKey();
        }
    }
}
