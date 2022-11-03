using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOrnek
{
    class Muhendis : Calisan
    {
        // constructors

        public Muhendis(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.pIsTanimi = "Stajyer Mühendis";
            this.pMaas = 4000;
            this.pTatilGun = 14;
        }

        public Muhendis(string ad, string soyad, int maas)
        {
            pIsTanimi = "Mühendis";
            this.ad = ad;
            this.soyad = soyad;
            this.pIsTanimi = IsTanimiYarat(maas);
            this.pMaas = maas;
            setTatilGun();
        }
    }
}
