using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Efe";
            musteri1.Soyadi = "Gür";
            musteri1.TcNo = "12345678910";


            //kodlama io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "56321";
            musteri2.SirketAdi = "Kodlama io";
            musteri2.VergiNo = "4643212";


            Musteri musteri3 = new GercekMusteri();// hem gerçeğin hem tüzelin referansını tutabiliyor 
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);


          


        }
    }
}
