using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsztalyDia2
{
    public abstract class BankFelhasznalo
    {

        private string felhasznaloszama;
        private decimal osszeg;

        

        public decimal Osszegvissza()
        {

            return osszeg;

        }
        public void Osszegfrissit(decimal ossz)
        {

            osszeg += ossz;

        }


    }
}
