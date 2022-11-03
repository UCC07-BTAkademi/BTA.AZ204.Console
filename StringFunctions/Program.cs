using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            // String işlemlerinde kullanılan bazı fonksiyon örnekleri

            #region Bir karakteri istenen sayıda olacak şekilde yazdırmak

            //string KarakterEkle = new string('M', 5);
            //// sadece tek bir karakter yazabilirsiniz

            //Console.WriteLine(KarakterEkle);

            #endregion

            #region Bir string  değerin karakter sayısını bulmak

            //string KK = " umitkaracivi.com.tr ";

            //int KarakterSayisi = KK.Length;

            //// Karakter katarı içindeki karakterlerin sayısını verir.
            //// Bırakılan boşluklarda sayılır
            //// Int değer döner.

            #endregion

            #region Bir string değerin belirli bir parçasını silmek

            //string KK1 = "umitkaracivi.com.tr";

            //string KK1_Yeni = KK1.Remove(0, 7);
            //// ilk karaterden itibaren 7 karekter silindi

            #endregion

            #region Bir string değerin belirli bir parçasını değiştirmek

            //string KK2 = "Ümit,Karaçivi, com";

            //string KK2Replace = KK2.Replace(",", string.Empty).Replace(" ", ".").Replace("Ü", "u").Replace("ç","c").Replace("K","k");


            //// 1 - Tüm Virgülleri kaldırıldı.
            //// 2 - Tüm Boşlukları nokta yapıldı.
            //// 3 - Tüm Ü harflarini u yapıldı.
            //// 4 - Tüm ç ler c yapıldı
            //// 5 - Tüm K lar k yapıldı
            //Console.WriteLine(KK2Replace);

            //#endregion

            //#region Bir string değerdeki boşlukları silmek

            //string KK3 = "  Ümit,Karaçivi, com   ";

            //string KK3Trim_start = KK3.TrimStart(); // değerin başındaki boşlukları siler.
            //string KK3Trim = KK3.Trim(); //   değerin hem başındaki hem de sonundaki boşlukları siler.
            //string KK3Trim_end = KK3.TrimEnd(); //   değerin sonundaki boşlukları siler.

            #endregion

            #region Bir string değerin istediğimiz karakter ile başlayıp başlamadığını ya da bitip bitmediğini kontrol etmek

            //string KK4 = "Ümit,Karaçivi, com";

            //string Kontrol = "com";

            //string mesaj;

            //// StartsWith
            //if (KK4.StartsWith(Kontrol))
            //    mesaj="Değerin başında " + Kontrol + " bulundu.";
            //else
            //    mesaj="Değerin başında " + Kontrol + " bulunamadı.";

            //// EndsWith
            //if (KK4.EndsWith(Kontrol))
            //    mesaj="Değerin sonunda " + Kontrol + " bulundu.";
            //else
            //    mesaj="Değerin sonunda " + Kontrol + " bulunamadı.";

            //Console.WriteLine(mesaj);

            #endregion

            #region Bir string değerdeki tüm harfleri büyük veya küçük yapmak

            //string KK5 = "Ümit,karaçivi, com";

            //string KKP_ToUpper = KK5.ToUpper(); // tüm karakterleri büyük harf yapar
            //Console.WriteLine(KKP_ToUpper);
            //string KK5_ToLower = KK5.ToLower(); // tüm karakterleri küçük harf yapar.

            #endregion

            #region Bir string değerdeki belirli bir karakterden yazıyı ayrıştırmak

            //string KK6 = "Ümit,Karaçivi, com";

            //string[] KK6_Split = KK6.Split(',');
            //// Değerdeki görünen her virgülde yazıyı parçalayıp bir ArrayList'e atar.
            //// Çıktı : 
            //// KK6_Split[0] = "Ümit"
            //// KK6_Split[1] = "Karaçivi"
            //// KK6_Split[2] = " com"

            //Console.WriteLine(KK6_Split[1]);

            #endregion

            #region Bir string değeri kopyalamak

            //string KK7 = "Ümit,Karaçivi, com";

            //object KK7_Clone1 = KK7.Clone();
            //// String olan bir değişkeni object türündeki bir değişkene klonlamamızı sağlar.
            //object KK7_Clone2 = KK7;
            //// Bu şekilde de aynı sonucu alırız.
            //string KK7_Clone3 = KK7.Clone().ToString();
            //// Bu şekilde de aynı sonucu alırız.

            #endregion

            #region Farklı string değerleri karşılaştırmak

            //string KarDeg2 = "M";
            //string KarDeg3 = "U";

            //int Comp1 = string.Compare(KarDeg2, KarDeg3);
            //// compare işleminde sonuç int olarak döner.
            //// M harfi alfabede U harfinden önce gelir.
            //// Değer tek harf ise, ilk parametre karakter sıralamasına göre önce ise -1 döner
            //// Çıktı : -1

            //Console.WriteLine(Comp1.ToString());

            //string KarDeg4 = "Ra";
            //string KarDeg5 = "Mi";

            //int Comp2 = string.Compare(KarDeg4, KarDeg5); 
            //// compare işleminde sonuç int olarak döner.            
            //// Alfabetik sıraya göre Ra hecesi Mi hecesinden sonra gelir.
            //// Bu sebeple Çıktı : 1 olacaktır.

            //Console.WriteLine(Comp2.ToString());

            //string KarDeg6 = "ÜM";
            //string KarDeg7 = "Üm";

            //int Comp3 = string.Compare(KarDeg6, KarDeg7); 
            //// compare işleminde sonuç int olarak döner.            
            //// İki değerde aynı ise
            //// Çıktı : 0 olacaktır.

            //Console.WriteLine(Comp3.ToString());

            //// Büyük küçük harflere duyarlıdır. 
            //// Küçük harfler alfabetik olarak büyük harflerden önce gelmektedir.
            //// Büyük küçük harf duyarlılığını iptal etmek istersek aşağıdaki şekilde kullanırız.
            //int Comp4 = string.Compare(KarDeg6, KarDeg7, true);

            //Console.WriteLine(Comp4.ToString());

            #endregion

            #region KK değerlerinin aynı olup olmadığını kontrol etmek

            //string KK9 = "Ümit,Karaçivi, com";
            //string KK10 = "Ümit,Karaçivi, com ";

            //bool EsitMi = KK9.Equals(KK10); 
            
            //// aynı mı değil mi kontrolü sağlar.
            //// Değişkenler aynı ise true değilse false döner.
            //// Bu işlemdeki sonuç -false- olacaktır. Sebebi ise KK10 değişkenin sonunda fazladan bir boşluk vardır.

            #endregion

            #region Bir KK değerin içinde arama yapmak_1

            //string KK11 = "Ümit,Karaçivi, com";

            //string KKArama_1 = "Kar";

            //int sonuc1 = KK11.IndexOf(KKArama_1); 
            //// IndexOf işleminde geriye int değer döner.
            //// Aranan ifade bulunursa, aranan ifadenin ilk harfinin bulunduğu index no'su alınır.
            //// Aranan ifade bulunmazsa, sonuç -1 döner.
            //// Aramada büyük/küçük harf duyarlılığı vardır.

            //// Bu işlemdeki Sonuç: -1 olacaktır.

            //// Büyük/Küçük harf duyarlılığı istenmiyorsa aşağıdaki şekilde kullanılır.

            //int sonuc2 = KK11.IndexOf(KKArama_1, StringComparison.InvariantCultureIgnoreCase);
            //// Bu işlemde sonuç : 5 olacaktır.

            //string KKArama_2 = "i";

            //int sonuc3 = KK11.LastIndexOf(KKArama_2, StringComparison.InvariantCultureIgnoreCase);
            //// LastIndexOf işleminde geriye int değer döner.
            //// Eşleşmenin bulunduğu en son index numarası alınır.
            //// Bu işlemdeki sonuç : 20 'dir.


            //Console.WriteLine(sonuc3.ToString());

            #endregion

            #region Farklı string değerlerini birleştirmek

            //string KK12 = "umitkaracivi.com.tr ";
            //string KK12Ek = "Kişisel internet sitesidir";

            //string sonuc4 = string.Concat(KK12, KK12Ek); // Iki string değeri birleştirir.
            //// bu işlem
            //string sonuc5 = KK12 + KK12Ek;
            //// bu işlemle aynı işi yapar.

            #endregion

            #region Bir string dizideki değerler arasına başka bir değer eklemek

            //string[] KK13Dizi = { "Ümit", "Karacivi", "com.tr" };

            //string.Join(",", KK13Dizi); // Dizideki değerler arasında virgül ekler
            ////Çıktı : "Ümit,Karaçivi,com.tr" olacaktır.

            //string.Join("\n", KK13Dizi);
            //// Dizideki değerleri alt alta ekler.
            ////Çıktı : 
            ////Ümit
            ////Karaçivi
            ////com.tr
            ////olacaktır.

            #endregion

            #region Bir karakter katarına belirtilen indexden itibaren bir karakter eklemek

            //string KK14 = "Merhaba Dünya";

            //Console.WriteLine(KK14.Insert(7, ","));

            #endregion

            #region  belirtilen string değerinin boş ve null olup olmadığını kontrol etmek

            //string KK15 = "Merhaba Dünya";
            //string KK16 = "";
            //string KK17 = null;

            //Console.WriteLine("String KK15 {0}.", string.IsNullOrEmpty(KK15));
            //Console.WriteLine("String KK16 {0}.", string.IsNullOrEmpty(KK16));
            //Console.WriteLine("String KK17 {0}.", string.IsNullOrEmpty(KK17));

            #endregion

            #region PadLeft,PadRight

            //string KK18 = "Merhaba Dünya";
            //string KK19 = KK18.PadLeft(16);
            //Console.WriteLine(KK19);


            //string KK20 = "Merhaba Dünya";

            //Console.Write(KK20.PadRight(20));
            //Console.WriteLine("|");

            #endregion

            #region string içerisinde başlangıç index değerinden itibaren tüm değeri geriye döner

            //string KK21 = "Merhaba Dünya";
            //Console.WriteLine(KK21.Substring(4));

            #endregion


            Console.ReadKey();
        }
    }
}
