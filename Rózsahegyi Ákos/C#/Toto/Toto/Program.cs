using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\Toto\Toto\bin\Debug\toto.txt");
            List<totoData> database = new List<totoData>();
            for (int i = 1; i < inputs.Length; i++)
            {
                totoData temp = new totoData(inputs[i]);
                database.Add(temp);
            }
        }
    }
}
