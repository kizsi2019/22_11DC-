using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[20];
            //Randomolás 
            Random r = new Random();

                int[] paratlan = new int[randT.Length];
                int g = 0;
                int db = 0;
                int leggisebb = 0;
                int legnagyobb = 0;
                int h = 0;
                int v = 0;

                for (int i = 0; i < randT.Length; i++)
                {
                    randT[i] = r.Next(0, 101);
                }

                foreach (int item in randT)
                {
                    Console.Write(item + ", ");
                }

                while (g < randT.Length && randT[g] < 20)
                {
                    g++;
                }
                if (g < randT.Length) Console.WriteLine("\nVan 20nal gissebb");
                else Console.WriteLine("Nincs 20nal gissebb");

                for (int l = 0; l < randT.Length; l++)
                {
                    if (randT[l] % 3 == 0) db++;
                }
                Console.WriteLine("{0} db paros van benne", db);

                for (int o = 0; o < randT.Length; o++)
                {
                    if (randT[o] > randT[legnagyobb]) legnagyobb = o;
                    if (randT[o] < randT[leggisebb]) leggisebb = o;
                }
                Console.WriteLine("Legnagyobb szam: {0}", randT[legnagyobb]);
                Console.WriteLine("Leggissebb szam: {0}", randT[leggisebb]);

                while (h < randT.Length && randT[h] % 3 != 0)
                {
                    h++;
                }
                if (h < randT.Length) Console.WriteLine("Van 3al oszthato, sorszama: {0}", h);
                else Console.WriteLine("Nincs 3al oszthato");

                for (int y = 0; y < randT.Length; y++)
                {
                    if (randT[y] % 3 == 0)
                    {
                        paratlan[v] = randT[y];
                        v++;
                    }
                }

                foreach (int item in paratlan)
                {
                    Console.Write(item + ", ");
                }

                for (int g = randT.Length - 1; g > 1; g--)
                {
                    for (int e = 0; e < g; e++)
                    {
                        if (randT[e] > randT[e + 1])
                        {
                            int csere = randT[e];
                            randT[e] = randT[e + 1];
                            randT[e + 1] = csere;
                        }
                    }
                }

                Console.WriteLine("\nBuboreg rendezessel:");
                foreach (int item in randT)
                {
                    Console.Write(item + ", ");
                }
                Console.ReadKey();
                     }
                }
            }