﻿using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;                        DEĞER TİP   

            // sayi2 = 100;

            //Console.WriteLine( "sayi 1 :" + sayi1);


            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            kisi1.Ad = "Efekan";

            kisi2 = kisi1;
            kisi1.Ad = "değişen Ad";
            Console.WriteLine(kisi2.Ad);  // referans tip  

            Musteri musteri = new Musteri();
            musteri.Ad = "Ekin";
            Yönetici yönetici = new Yönetici();
            yönetici.Ad ="Efe";
            Kisi kisi3 = musteri; // miras aldığımız kisiye değer atayabiliriz ama yeni bir işi olması gerekiyor değer 
            Console.WriteLine(kisi3.Ad);    //   kisi3. yazınca yönetici no gözükmüyor


            Console.WriteLine(((Musteri)kisi3).CreditCardNumber );


            PersonManager personManager = new PersonManager();
            personManager.Add(yönetici);  // istersek önetici istersek müşteri istersek de kişi yi kullanabiliriz ***************
           

            
        }
        class Kisi
        {
            public int Id { get; set; }
            public String Ad{ get; set; }
            public string Soyad { get; set; }


        }
        class Musteri:Kisi
        {
          public String CreditCardNumber { get; set; }
        }
        class Yönetici:Kisi
        {
          public int YöneticiNo { get; set; }
        }
        class PersonManager
        {
            public void Add (Kisi kisi)            // istediğimizle çalışmamızı sağlayacak  kod  kişi yeride müşteri ve yöneticiyi de kapsar 
                                                        // 38 satıra bak
            {
                Console.WriteLine(kisi.Ad);
            }
        }
 
    }
}