using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna kolme lukua: ");
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());

            {
                if (luku1 < luku2 && luku2 < luku3)
                    Console.WriteLine("Suurin luku on:" + luku3);

                if (luku1 > luku2 && luku1 > luku3)
                    Console.WriteLine("Suurin luku on:" + luku1);

                if (luku2 > luku1 && luku2 > luku3)
                    Console.WriteLine("Suurin luku on:" + luku2);
            }
        }
    }
}
