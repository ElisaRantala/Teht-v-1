using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydä numero/pistemäärä
            int luku;
            Console.Write("Anna pistemäärä > "); 
            string line = Console.ReadLine();  
            bool result = int.TryParse(line, out luku);
            if (result == true)
            {


                // mikä numero
                switch (luku)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("0");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("1");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("2");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("3");
                        break;
                    case 8:
                    case 9 :
                        Console.WriteLine("4");
                        break;
                    case 10:
                    case 11:
                        Console.WriteLine("5");
                        break;
                    case 12:
                        Console.WriteLine("5");
                        break;
                    default:
                        Console.WriteLine("väärä pistemäärä");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not integer value!");
            }
            // wait enter
            Console.ReadLine();
        }
    }
}
