using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager// ürünle ilgili operasyonlar vardır
       //int double bool... değer tip
        //diziler class abstract class interface ...referans tip
        //ref out 

    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //public void update(product product)
        //{
        //    console.writeline(product.productname + " güncellendi");
        //}
        //public int topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void topla2(int sayi1, int sayi2)// neden int değil
        //{
        //    console.writeline(sayi1 + sayi2);// void git yap bitir sonra işin olmaz
        //}
        //public int topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void topla2(int sayi1, int sayi2)// neden int değil
        //{
        //    console.writeline(sayi1 + sayi2);// void git yap bitir sonra işin olmaz
        //}

    }
}
