using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes_pelda__2022.XII._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            StreamReader sr = new StreamReader(@"C:\Users\SarkadiKristofStefan\Desktop\sark.kris.stef\22_11DC-\Sarkadi Kristóf\osszegzes_pelda__2022.XII.01\osszegzes_pelda__2022.XII.01\bin\Debug\díszek.txt");
            while (!sr.EndOfStream)
            {
                lista.Add(int.Parse(sr.ReadLine()));
            }
            sr.Close();
            int összes = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                összes += lista[i];
            }
            Console.WriteLine("Ennyi karácsonyi díszt készölt:" + összes);
            Console.ReadKey();
        }
    }
}
