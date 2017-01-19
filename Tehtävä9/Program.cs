using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä9
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, sum;
            sum = 0;
            {
                do
                {
                    Console.WriteLine("Anna luku: ");
                    luku = int.Parse(Console.ReadLine());
                    sum = sum + luku;

                } while (luku != 0);
                Console.WriteLine("Lukujen summa: " + sum);

            }
        }
    }
}
