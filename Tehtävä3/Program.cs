using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku1, luku2, luku3, sum;
            double keskiarvo;
            Console.WriteLine("Anna 3 lukua: ");
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());
            // laskee summan
            sum = (luku1 + luku2 + luku3);
            // laskee keskiarvon 
            keskiarvo = (sum / 3.0);           
            Console.WriteLine("Lukujen summa:" + sum);
            Console.WriteLine("Keskiarvo:" + keskiarvo);

        }
    }
}
