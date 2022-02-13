using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            // int decimal flaoat bool =değer tipler (sayısal ifadesini alır) 

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            Console.WriteLine(sayılar1[0]);
            //array, class interface =referans tipler(artık sayılar 1 sayılar 2nin gittiği yere gider)








        }
    }
}
