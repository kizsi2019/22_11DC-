using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalasztas_pel__2022.XII._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\SarkadiKristofStefan\Desktop\sark.kris.stef\22_11DC-\Sarkadi Kristóf\kivalasztas_pel__2022.XII.05\kivalasztas_pel__2022.XII.05\bin\Debug\névsór");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            String név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] != név)
        }
    }
}
