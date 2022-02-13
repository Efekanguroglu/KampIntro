using System;

namespace Metotlar
{
    class Program
    { 
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyatı = 15;
            string acıklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.Fiyati = 80;


            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler) 
            {   
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("------------");



            }
            Console.WriteLine("---------------Metotlar----------------");
            // instance örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // iki tane ürün olduğu için  
            sepetManager.Ekle2("Akıllı saat", "Huawei", 1500, 5 );
            sepetManager.Ekle2("Telefon", "Apple", 15000, 3);
            sepetManager.Ekle2("Bilgisayar", "HP   ", 17000,6);




        }

    }
}    



//Don,t repeat yourself
