using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\szetvalogatas_pelda\szetvalogatas_pelda\bin\Debug\szamok.txt");
            int[] szamokt = new int[100];
            int j = 0;
            while (!sr.EndOfStream)
            {
                szamokt[j] = int.Parse(sr.ReadLine());
            }

            int[] negyzetszamokt = new int[100];
            int[] oszthato3szamokt = new int[100];
            int negyzet_i = 0, osz3_i = 0;
            for (int i = 0; i < szamokt.Length; i++)
            {
                if (szamokt[i] > 0 && Math.Sqrt(szamokt[i]) % 1 == 0)
                {
                    negyzetszamokt[negyzet_i] = szamokt[i];
                    negyzet_i++;
                }
                if (szamokt[i] % 3 == 0)
                {
                    oszthato3szamokt[osz3_i] = szamokt[i];
                    osz3_i++;
                }
            }

            Console.WriteLine("Négyzetszámok: ");
            for (int i = 0; i < negyzetszamokt.Length; i++)
            {
                Console.WriteLine(negyzetszamokt[i]);
            }
            Console.WriteLine("Hárommal oszthatók: ");
            for (int i = 0; i < oszthato3szamokt.Length; i++)
            {
                Console.WriteLine(oszthato3szamokt[i]);
            }
            Console.ReadKey();
        }
    }
}
