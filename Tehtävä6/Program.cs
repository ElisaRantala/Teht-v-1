using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä6
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            double k, h; 
            Console.WriteLine("Anna matka: ");
            km = int.Parse(Console.ReadLine());
            k = km * 0.0702;
            h = k * 1.595;
            Console.WriteLine("Bensaa kuluu: "  + k  + "l, " + "kustannus " + h  + "e"); 
        }
    }
}
