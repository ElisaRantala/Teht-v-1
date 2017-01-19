using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, min, sek, luku;
            Console.WriteLine("Anna sekuntit: ");
            luku = int.Parse(Console.ReadLine());
            h = (luku / 3600);
            min = luku / 60 - h * 60;
            sek = luku % 60;
            Console.WriteLine("Antamasi luku voidaan ilmaista muodossa:" +  h + "h " +  min + "min " + sek + "sek");
        }
    }
}
