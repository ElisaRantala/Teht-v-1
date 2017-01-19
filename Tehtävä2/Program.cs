using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydä numero
            int luku;
            Console.Write("Anna numero > ");
            string line = Console.ReadLine();  // "1"
            bool result = int.TryParse(line, out luku);
            if (result == true)
            {


                // mikä numero
                switch (luku)
                {
                    case 1:
                        Console.WriteLine("yksi");
                        break;
                    case 2:
                        Console.WriteLine("kaksi");
                        break;
                    case 3:
                        Console.WriteLine("kolme");
                        break;
                    default:
                        Console.WriteLine("joku muu luku");
                        break;
                }
            } else
            {
                Console.WriteLine("Not integer value!");
            }
            // wait enter
            Console.ReadLine();
        }
    }
}
