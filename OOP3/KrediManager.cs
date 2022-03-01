using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager //interface kullanırsa alttaki methodu içermek zorunda (interface {[(I)]} harfi ile başlar )  bizim için referans tutsun diye
                            //ve tüm kredi tiplerinin uygulaması zorunlu halde olması istenen operasyonları tutsun diye bu interfaceleri oluştururuz 
    {
        void Hesapla(); //operasyonel methotlarda kullanırız

        void BiseyYap();

        

        
    }
}
