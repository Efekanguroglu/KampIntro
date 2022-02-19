using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Efekan","Halil","Melih","Ahmet" };
            //Console.WriteLine(isimler[0]);                                         // sabitlik var  5 elemanlı  6.yı yazarsan ötekileri kaybedersin!!!!
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            // isimler = new string[5];                                               üstteki değerleri kaybederiz  bunu da bir anlamı olmaz!!!!
            //isimler[4] = "İlker";
            //  Console.WriteLine(isimler[4]);

                                                     //KOLEKSİYONLAR//
                                         //arrayların yanı sıra ekstra ekleme yapaibiliriz!!!

            List<string> isimler2 = new List<string> { "Efekan", "Halil", "Melih", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);





        }
    }
}
