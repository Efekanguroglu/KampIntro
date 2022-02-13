using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Grliştirici Yetiştirme kampı";
            string kurs2 = "Programlamaya başlangı. için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";// manuel yaparız o zaman işler uzar karmakarışık bir hal alır.
                                 // kurs5 console yazmam gerek

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            // 2 defa yazar alltaki kolay kendini tekrarlamazsın...


            //array- dizi

            string[] kurslar = new string[] { "Yazılım Grliştirici Yetiştirme kampı", "Programlamaya başlangı.için temel kurs"
                ,"Java","Python","C++" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek döner.
            {
                   
            }
                 Console.WriteLine("Sayfa sonu- footer");
        }
    }
}
