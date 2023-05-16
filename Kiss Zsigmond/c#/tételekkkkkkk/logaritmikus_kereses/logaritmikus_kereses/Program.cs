using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logaritmikus_kereses
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 }; 
            //Logaritmikus keresés
            int alsóhatár = 0; 
            int felsőhatár = rendezettTömb.Length - 1; 
            int közép = 0;
            Console.Write("Adj meg számot! ");
            int X = int.Parse(Console.ReadLine());
            do { 
                közép = (alsóhatár + felsőhatár) / 2; 
                if (rendezettTömb[közép] < X) alsóhatár = közép + 1; 
                if (rendezettTömb[közép] > X) felsőhatár = közép - 1; 
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != X); 
            if (rendezettTömb[közép] == X) Console.WriteLine("Van, indexe: " + közép); 
            else Console.WriteLine("Nincs");
            Console.ReadKey();
        }
    }
}
