﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyDia2
{
    public abstract class BankFelhasznalo
    {

        private int felhasznaloszama;
        private int osszeg;

        public BankFelhasznalo(int felhasznaloszama, int osszeg)
        {
            this.felhasznaloszama = felhasznaloszama;
            this.osszeg = osszeg;
        }

        public virtual void Nev()
        {

            Console.WriteLine(string.Format("Felhasználó Száma: {0}", this.felhasznaloszama));
            Console.WriteLine(string.Format("Felhasználó Összege: {0:# ### ###}", this.osszeg));

        }
        public static void Osszegvissza()
        {



        }
        public static void Osszegfrissit()
        {



        }


    }
}
