using System;
using System.Collections.Generic;

namespace Generiicss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İzmir");
            MyList<string> sehirler2 = new MyList<string>();   // isterek <type>da diyebiliriz
            sehirler2.Add("İstanbul");
        }

    }
    class MyList<Y> // Generic class rastgele olabilir
    {
        public void Add(Y items)      // yukarda ne kullanırsak o devreye girer type genel bir class oldu
        {

        }   
    }
}
