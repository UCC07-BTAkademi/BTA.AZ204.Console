using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOrnek
{
    class Calisan
    {
        ///---> Değişken Tanımlaması <---\\\
        private int maas,tatilgun,eskimaas;

        private string istanimi = "Çalışan";
        
        public string ad, soyad;

        ///---> Private Değişkenlere Erişmek İçin <---\\\
        public int pMaas
        {
            get { return maas; }
            set { maas = value; }
        }
        public int pTatilGun
        {
            get { return tatilgun; }
            set { tatilgun = value; }
        }
        public string pIsTanimi
        {
            get { return istanimi; }
            set { istanimi = value; }
        }
        ///---> Constructor Metot Yapıları <---\\\
        public Calisan()
        {
            this.ad = null;
            this.soyad = null;
            this.istanimi = null;
            this.maas = 0;
            this.tatilgun = 0;
        }

        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.istanimi = "Stajyer";
            this.maas = 2900;
            this.tatilgun = 7;
        }

        public Calisan(string ad, string soyad, int maas)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.maas = maas;
            this.istanimi = IsTanimiYarat(maas);
            setTatilGun();
        }
        ///---> Metot Tanımlamaları <---\\\
        public string IsTanimiYarat(int maas)
        {
            if (istanimi.Contains("Çalışan") == true)
            {
                if (maas >= 2900 && maas <= 3900)
                    return "Vasıfsız Çalışan";
                else if (maas > 3900 && maas <= 4900)
                    return "Vasıflı Çalışan";
                else if (maas > 4900 && maas <= 5900)
                    return "Kıdemli Çalışan";
                else if (maas > 5900)
                    return "Uzman Çalışan";
                else
                    return "Stajyer";
            }
            else if (istanimi.Contains("Mühendis") == true)
            {
                if (maas >= 5000 && maas <= 6000)
                    return "Mühendis";
                else if (maas > 6000 && maas <= 7000)
                    return "Kıdemli Mühendis";
                else if (maas > 7000)
                    return "Uzman Mühendis";
                else
                    return "Stajyer Mühendis";
            }
            else
                return "Stajyer";
        }

        public void setTatilGun()
        {
            if (istanimi.Contains("Çalışan"))
            {
                if (istanimi.Contains("Uzman"))
                    tatilgun = 28;
                else if (istanimi.Contains("Kıdemli"))
                    tatilgun = 21;
                else
                    tatilgun = 14;
            }
            else
            {
                if (istanimi.Contains("Uzman"))
                    tatilgun = 35;
                else if (istanimi.Contains("Kıdemli"))
                    tatilgun = 28;
                else
                    tatilgun = 21;
            }
        }

        public void ZamYap(int zammik)
        {
            eskimaas = maas;
            ///---> Mühendislere Ekstra %10 Zam Uygulanıyor <---\\\
            if (istanimi.Contains("Mühendis"))
            {
                maas += zammik;
                maas = maas + Convert.ToInt32(maas * 0.1);
                istanimi = IsTanimiYarat(maas); // maaşına göre iştanımı ve tatil gün sayısı yeniden ayarlanıyor.
                setTatilGun();
            }
            else if (istanimi.Contains("Çalışan"))
            {
                maas += zammik;
                istanimi = IsTanimiYarat(maas);
                setTatilGun();
            }
        }

        public void KisiBilgi()
        {
            Console.WriteLine($"\n< {istanimi} Bilgileri >\n-> Personel İsmi: {ad}\n-> Personel Soyismi: {soyad}\n-> Görevi: {istanimi}\n-> Maaşı: {maas} TL\n-> İzin Günü: {tatilgun} Gün\n");
        }

        public void ArtisBilgi()
        {
            if (eskimaas != 0)
                Console.WriteLine($"\n < {istanimi} Zam Uygulaması >\n-> Personelin Eski Maaşı: {eskimaas} TL\n-> Yeni Verilecek Maaş: {maas} TL\n-> Yeni izin günü : {tatilgun} Gün\n");
        }
    }
}
