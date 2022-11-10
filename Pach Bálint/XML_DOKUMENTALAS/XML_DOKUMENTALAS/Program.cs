using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_DOKUMENTALAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary> Ez a függvény átkonvertálja a kapott string bináris számot decimális számmá </summary>
            /// <param name="bin">Bináris szám</param>
            /// <param name="dec">Ha sikerül a konvertálás, ide kerül az átalakított szám</param>
            /// <returns>Ha sikerült a konvertálás true, ha nem false értékkel tér vissza</returns>
            /// <exception cref="System.OverflowException"/>
            static bool KonvBinDec(string bin, out int dec)
            {
                dec = 0;
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] == '1') dec += (int)Math.Pow(2, bin.Length - 1 - i);
                    else if (bin[i] != '0') dec = 0; return false;
                }
                return true; 
            }
        }
    }
}
