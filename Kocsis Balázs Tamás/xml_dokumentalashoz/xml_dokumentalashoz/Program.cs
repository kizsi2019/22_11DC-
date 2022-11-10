using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_dokumentalashoz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool v = KonvBinDec("1111", out int szam);
            Console.WriteLine(v);
            Console.WriteLine(szam);

            Console.ReadKey();
        }
        static bool KonvBinDec(string bin, out int dec)
            {
                /// <summary>fffffffff</summary>
                /// <param name="bin">ffffffffffff</param>
                /// <param name="dec">ddddddddddd</param>
                /// <returns>gggggggggggg</returns>
                /// <exception cref="System.OverflowException"/>
                dec = 0;
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] == '1')
                    {
                        dec+= (int)Math.Pow(2,bin.Length - i);
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

