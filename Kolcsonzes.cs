using System;
using System.Collections.Generic;
using System.Text;

namespace KajakKolcsonzo
{
    public class Kolcsonzes
    {
        public string BerloNev { set; get; }
        public string HajoTipus { set; get; }
        public int BereltOrak { set; get; }
        public int MentoMellenyek { set; get; }
        public int KesesPerc { set; get; }
        public Kolcsonzes(string sor)
        {
            string[] adatok = sor.Split(";");
            BerloNev = adatok[0];
            HajoTipus = adatok[1];
            BereltOrak = int.Parse(adatok[2]);
            MentoMellenyek = int.Parse(adatok[3]);
            KesesPerc = int.Parse(adatok[4]);
        }
        public int FizetendoOsszeg() {
            int oszeg=0;
            if (HajoTipus == "KAJAK")
            {
                oszeg += 2500 * BereltOrak;
            }
            else
            {
                oszeg += 4000 * BereltOrak;
            }
            if (MentoMellenyek >= 2)
            {
                oszeg += 500 * (MentoMellenyek - 1);
            }
            if (KesesPerc > 15)
            {
                oszeg += 3000;
            }
            return oszeg;
        }
        public override string ToString()
        {
            return $"{BerloNev} ({HajoTipus}): {BereltOrak} óra, {MentoMellenyek} mentőmellény, {KesesPerc} perc késés - Fizetendő: {FizetendoOsszeg()} Ft";
        }
    }
}
