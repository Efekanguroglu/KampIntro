using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program   // arayüzde hangisini seçersek o krediyi alacak
    {
        static void Main(string[] args)  //şubedeki arkadaşın ekranı ****!!!!!
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();    //Aynı sonucu alırız interfaceler de o interface implement eden classını da tutabiliyormuş        
            IKrediManager tasıtKrediManager = new TasıtKrediManager();    //KrediManager de yazabilirdik TasıtKrediManager tasıtKrediManager diye de
            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(konutKrediManager);     // ne yazarsak o çalışır

            List<IKrediManager> krediler = new List<IKrediManager>(){ tasıtKrediManager, konutKrediManager }; // <----buraya ne eklersek o çalışır

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
} 
