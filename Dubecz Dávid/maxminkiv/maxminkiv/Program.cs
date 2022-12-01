using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxminkiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb = 0;
            int legkissebb = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[legnagyobb]) legnagyobb = 1; 
                if (tomb[i] > tomb[legkissebb]) legkissebb = 1;

            }
            Console.WriteLine("Legnagyobb {0}, erteke {1}", legnagyobb, tomb[legnagyobb]);
            Console.WriteLine("Legkissebb {0}, erteke {1}", legkissebb, tomb[legkissebb]);
        }
    }
}
