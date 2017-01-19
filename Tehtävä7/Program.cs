using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Anna vuosi: ");
            luku = int.Parse(Console.ReadLine());
            {
                if (luku % 4 == 0 && luku % 100 != 0 || luku % 400 == 0)
                    Console.WriteLine("Vuosi on karkausvuosi");

                else
                {
                    Console.WriteLine("Ei ole karkausvuosi");


                }
            }
        }
    }
}
