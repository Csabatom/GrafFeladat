using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);
            //graf.Torol(3, 2);
            //graf.Torol(4, 5);
            //graf.Torol(5, 4);
            //graf.SzelessegiBejar(3);
            //graf.MelysegiBejar(3);
            //Console.WriteLine(graf.Osszefuggoseg());

            Console.WriteLine(graf);
            Console.ReadLine();
        }
    }
}
