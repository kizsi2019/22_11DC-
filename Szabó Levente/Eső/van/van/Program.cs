using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace van
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] van = new int[222];
            int[] nemvan = new int[222];
            int[] eredmény = new int[222];
            int lehet = 0;

            for (int i = 0; i < 222; i++)
            van[i] = r.Next(2, 10);
            nemvan[i] = r.Next(1, 5);
            eredmény = van[i] - nemvan[i];
            Console.WriteLine("hete", + lehet);
        }
    }
}
