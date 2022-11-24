using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool v = konv("1111", out int szam);
            Console.WriteLine(v);
            Console.WriteLine(szam);
            Console.ReadKey();
        }

        static bool konv(string bin, out int dec)
        {
            /// <summary> Ez a függvény átkonvertálja a kapott string bináris számot decimális számmá </summary>
            /// <param name="bin">Bináris szám</param>
            /// <param name="">Ha sikerül a konvertálás, ide kerül az átalakított szám</param>
            /// <returns>Ha sikerült a konvertálás true, ha nem false értékkel tér vissza</returns>
            /// <exception cref="System.OverflowException"/>
            dec = 0;

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    dec += (int)Math.Pow(2, bin.Length - i);
                }
                else if (bin[i] != '0')
                {
                    dec = 0;
                    return false;
                }
            }
            return true;
        }
    }
}
