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


            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtKrediManager, dataBaseLoggerService);      // new EsnafKrediManager diyerek de üstte  instance da oluşturabilirsin

            List<IKrediManager> krediler = new List<IKrediManager>(){ tasıtKrediManager, konutKrediManager }; // <----buraya ne eklersek o çalışır

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); // intarfaceleri birbirlerinin alternatifleri olan ama kod içerikleri farklı olan kodlar için kullanırız.
        }
    }
} 
