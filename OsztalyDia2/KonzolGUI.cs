using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyDia2
{
    class KonzolGUI
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nA Program kezdődik...");

            MostaniFalhasznalo mostanifelhasznalo1 = new MostaniFalhasznalo();
            Console.WriteLine("\nMostani Felhasználó");
            mostanifelhasznalo1.Osszegfrissit(300000);
            Console.WriteLine(mostanifelhasznalo1.Osszegvissza());


            FelretettFelhasznalo felretettfelhasznalo1 = new FelretettFelhasznalo();
            Console.WriteLine("\nFélretett Felhasználó");
            felretettfelhasznalo1.Osszegfrissit(120000);
            felretettfelhasznalo1.Osszegfrissit(1200000);
            Console.WriteLine(felretettfelhasznalo1.Osszegvissza());

            Console.WriteLine("\nA Program vége!");
            Console.ReadKey();
        }
    }
}
