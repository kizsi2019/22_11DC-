using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_getvalues_getnames
{
    class Program
    {
        enum RégiSúlymértékek : uint { Talentum = 30000, Mina = 500, Sékel = 11, Beka = 6 }
        static void Main(string[] args)
        {
            RégiSúlymértékek[] rsmT = (RégiSúlymértékek[])Enum.GetValues(typeof(RégiSúlymértékek)); 
            foreach (RégiSúlymértékek item in rsmT) 
            { 
                Console.WriteLine(item); 
            }
            string[] rsmTstr = Enum.GetNames(typeof(RégiSúlymértékek)); 
            foreach (string item in rsmTstr) 
            { 
                Console.WriteLine(item); 
            }
            string str = Enum.GetName(typeof(RégiSúlymértékek), 500); 
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
