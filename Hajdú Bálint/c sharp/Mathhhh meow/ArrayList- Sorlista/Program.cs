using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList__Sorlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sorlista = new ArrayList();
            sorlista.Add("string"); sorlista.Add(7); sorlista.Add('c');
            foreach (var item in sorlista)
            {
                Console.WriteLine(item);
            }
            StreamWriter sw_gyumolcsok = new StreamWriter("gyümölcsök.txt");
            sw_gyumolcsok.WriteLine("alma"); 
            sw_gyumolcsok.WriteLine("banán");
            sw_gyumolcsok.WriteLine("ananász");
            sw_gyumolcsok.WriteLine("körte");
            sw_gyumolcsok.Flush(); 
            sw_gyumolcsok.Close(); 
        }
    }
}
