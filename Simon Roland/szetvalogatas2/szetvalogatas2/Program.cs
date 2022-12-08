using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("szamok.txt");
            int[] szamokT = new int[100];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokT[j] = int.Parse(sr.ReadLine());
                j = j + 1;
            }
            sr.Close();
            int[] negyzetszamok = new int[100];
            int[] oszthato3szamok = new int[100];
            int negyzet_i = 0;
            int osz3_i = 0;
            for (int i = 0; i < szamokT.Length; i++)
            {
                if (szamokT[i] > 0 && Math.Sqrt(szamokT[i]) % 1 == 0)
                {
                    negyzetszamok[negyzet_i] = szamokT[i]; negyzet_i++;    
                }
                if (szamokT[i] % 3 == 0)
                {
                    oszthato3szamok[osz3_i] = szamokT[i];
                    osz3_i++;
                }
            }

        }
    }
}
