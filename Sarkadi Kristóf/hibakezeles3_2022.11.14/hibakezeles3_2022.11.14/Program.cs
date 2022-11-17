using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hibakezeles3_2022._11._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nullával ossztott!");
            }
            finally
            {
                //ez az ág mindenképpen lefut!
                Console.WriteLine("Vége");
            }
            Console.ReadKey();
        }
    }
}
