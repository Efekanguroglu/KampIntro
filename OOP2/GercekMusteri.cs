using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{            //Individual 
    class GercekMusteri:Musteri
    {
        
        public string TcNo { get; set; } //sayısal işlem yapmadığımız için string yazarız  sadece tc yi yazacağız ..
        
        public string Adi { get; set; } 
        public string Soyadi { get; set; }
    }
}
