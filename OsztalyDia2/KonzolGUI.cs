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

            MostaniFalhasznalo mostanifelhasznalo1 = new MostaniFalhasznalo(3, 120000);
            Console.WriteLine("\nMostani Felhasználó");
            mostanifelhasznalo1.Nev();

            FelretettFelhasznalo felretettfelhasznalo1 = new FelretettFelhasznalo(3, 1000000);
            Console.WriteLine("\nFélretett Felhasználó");
            felretettfelhasznalo1.Nev();

            Console.WriteLine("\nA Program vége!");
            Console.ReadKey();
        }
    }
}
