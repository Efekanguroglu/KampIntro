using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false; // veri kaynağından gelen bir değerdir başlnagıçta yazarız
            double dolarDun = 7.55;
            double dolarbugun = 7.45;

            if (dolarDun>dolarbugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if(dolarDun<dolarbugun)
            {
                Console.WriteLine("Artıs butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Lütfen giriş yapınız");
            }
           

            Console.WriteLine(kategoriEtiketi);
            



        }
    }
}
