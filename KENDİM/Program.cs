using System;

namespace KENDİM

{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "efekan ";
            int yas = 20;

            Kurs kurs1 =new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Efekan Güroğlu";
            kurs1.IzlenmeOrani = 31000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Ahmet Kargan";
            kurs2.IzlenmeOrani = 1000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Eğitmen = "samte Ulaşan";
            kurs3.IzlenmeOrani = 300;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Eğitmen+":"+kurs.IzlenmeOrani);
            }
        }

    }
    class Kurs  
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
