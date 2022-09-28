using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            Random random = new Random();
            byte randszam = (byte)random.Next(0, 101);
            byte tipp = 0;
            do
            {
                Console.WriteLine("Tipp: ");
                tipp = byte.Parse(Console.ReadLine());
                if (tipp < randszam)
                {
                    Console.WriteLine("Nagyobb szamra gondoltam");
                    db = db + 1;
                }
                else if (tipp > randszam)
                {
                    Console.WriteLine("Kisebb szamra gondoltam");
                    db = db + 1;
                }
                else
                    Console.WriteLine("Eltaláltad! " + db + " próbálkozásból");
            }while (tipp != randszam);

            Console.ReadKey();

        }
    }
}
