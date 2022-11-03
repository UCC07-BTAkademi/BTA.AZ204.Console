using System;

namespace PolymOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            ///---> Çalışan Sınıflarının Tanımlanması <---\\\
            Calisan calisan = new Calisan("Ali", "Veli", 3500);
            Calisan muhendis = new Muhendis("Osman", "Mosman", 5500);
            ///---> Kayıtların Ekran Çıktısını Oluşturalım <---\\\
            calisan.KisiBilgi();
            calisan.ZamYap(1240);
            calisan.ArtisBilgi();
            Console.WriteLine("");

            muhendis.KisiBilgi();
            muhendis.ZamYap(1240);
            muhendis.ArtisBilgi();

            Console.ReadKey();
        }
    }
}
