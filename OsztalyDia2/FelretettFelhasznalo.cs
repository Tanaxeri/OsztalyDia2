using System;

namespace OsztalyDia2
{
    public class FelretettFelhasznalo : BankFelhasznalo
    {
        private double terheles = 1.5;

        public void TerhelesSzam()
        {

            base.Osszegfrissit((decimal)((double)base.Osszegvissza() * this.terheles));

        }


        public decimal ErdekSzam()
        {

            return base.Osszegvissza();

        }

    }
}
