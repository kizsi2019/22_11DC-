using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tétel_feladatok
{
    internal class Program
        {
            static Random rnd = new Random();
            static int[] tmb = new int[20];
            static List<int> index = new List<int>();
            static void Main(string[] args)
            {
                for (int i = 0; i < tmb.Length; i++)
                {
                    tmb[i] = rnd.Next(0, 101);
                    Console.WriteLine($"{i + 1}. tartalma a tömbnek: {tmb[i]}");
                }

                bool haveLessthan20 = false;
                int counter = 0;
                while (haveLessthan20 == true || counter == tmb.Length)
                {
                    if (tmb[counter] <= 20)
                    {
                        haveLessthan20 = true;
                    }
                    counter++;
                }
                Console.WriteLine(haveLessthan20 ? "20-nál >szám" : "nincs 20-nál < szám a tömbben");

                int evenCounter = 0;
                foreach (var i in tmb)
                {
                    if (i % 2 == 0)
                    {
                        evenCounter++;
                    }
                }
                Console.WriteLine($"Páros szám(ok): {evenCounter}");

                int max = 0;
                int min = tmb[0];
                for (int i = 0; i < tmb.Length; i++)
                {
                    if (max < tmb[i])
                    {
                        max = tmb[i];
                    }
                    if (min > tmb[i])
                    {
                        min = tmb[i];
                    }
                }
                Console.WriteLine($"A leges legnagyobb : {max}");
                Console.WriteLine($"A leges legkisebb szám: {min}");
                bool isDivedable = false;
                for (int i = 0; i < tmb.Length; i++)
                {
                    if (tmb[i] % 3 == 0)
                    {
                        index.Add(tmb[i]);
                        if (isDivedable == false)
                        {
                            isDivedable = true;
                        }
                    }
                }
                if (isDivedable)
                {
                    Console.Write("Oszthato 20-al");
                    foreach (var i in index)
                    {
                        Console.Write($"{i}, ");
                    }
                }

                int oddsCounter = 0;
                for (int i = 0; i < tmb.Length; i++)
                {
                    if (tmb[i] % 2 != 0)
                    {
                        oddsCounter++;
                    }
                }
                int[] tmbOdds = new int[oddsCounter];
                for (int i = 0; i < tmb.Length; i++)
                {
                    if (tmb[i] % 2 != 0)
                        tmbOdds[i] = tmb[i];
                }
                Console.WriteLine("Páratlan: ");
                foreach (var i in tmbOdds)
                {
                    Console.Write($"{tmbOdds}, ");
                }

                for (int i = tmb.Length - 1; i >= 0; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (tmb[j] > tmb[j + 1])
                        {
                            int tmp = tmb[j];
                            tmb[j] = tmb[j + 1];
                            tmb[j + 1] = tmp;
                        }
                    }
                }
                for (int i = 0; i < tmb.Length; i++)
                {
                    Console.WriteLine($"{tmb.Length}, ");
                }
            Console.ReadKey();
            }
        }
    }

