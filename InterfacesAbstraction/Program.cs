using System;


// Interface (Arayüz)

// Bir çeşit sözleşme gibi düşünebiliriz. Her iki tarafın da üzerinde anlaştığı kurallar silsilesi.  Aynı zamanda bir durumun yapılabilirliğini de belirtir.
// Interfaceler den bir instance oluşturulamaz (yani new lenemez)
// Interfaceler içine kod yazılmaz. Sadece sözleşmenin kurallarını barındırır.



namespace InterfacesAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            var mercedes = new Mercedes();
            mercedes.YakitMaliyetiHesapla();

            var volvo = new Volvo();
            volvo.YakitMaliyetiHesapla();

            var model = volvo.GetModel();

            //var baseMarka = new BaseMarka();
            //baseMarka.



            var araba = new Araclar.Araba();
            araba.Git();
            araba.Dur();

            var bisiklet = new Araclar.Bisiklet();
            bisiklet.Bin();
            bisiklet.Git();
            bisiklet.Dur();

            var ucak = new Araclar.Ucak();
            ucak.Git();
            ucak.IniseGec();
            ucak.Dur();



        }
    }


}
