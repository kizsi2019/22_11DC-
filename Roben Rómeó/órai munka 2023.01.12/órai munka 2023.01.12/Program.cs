using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka_2023._01._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[20]; 


            Random rnd = new Random(); 


            for (int i = 0; i < 20; i++) 

            {

                tomb[i] = rnd.Next(0, 100); 

                Console.WriteLine(tomb[i]);

            }

            Console.WriteLine(""); 

            int bekértszám = int.Parse(Console.ReadLine()); 


            for (int i = 0; i < tomb.Length; i++) 


                if (tomb[i] >= -bekértszám && tomb[i] <= bekértszám) 

                    Console.WriteLine(tomb[i]); 



            Console.ReadKey();


        }
    }
}
