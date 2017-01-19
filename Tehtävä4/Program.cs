using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;   
            Console.WriteLine("Anna ikäsi > ");
            ika = int.Parse(Console.ReadLine());

            if (ika >= 0 && ika <= 17)
            {
                Console.WriteLine("Alaikäinen");
            }
        
            if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            
            if (ika > 65)
            {
                Console.WriteLine("seniori"); 
            }
           
        }
    }
}
