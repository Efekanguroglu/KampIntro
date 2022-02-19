using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro                                 // özel bir tipte çalışacağını belirtir
{
    class MyList<T>                                     //string int sepet classı her şeyi koyabiliriz   type ın T si
    {
        T[] items;                                      // string[] items;  yerine T koyarız 
                                                        // constructor                        ******ctor tab tab******
        public MyList()
        {
            items = new T[0];
        }

        

        public void Add(T item)                         // eleman da yazabilirsin  
        {
            T[] tempArray = items;                      // geçici dizinin referansı items in referansı arkadaşa  emanet etti eleman sayısı arttırmadan önce geçici referans tuttur
            items = new T[items.Length+1];              // dizinin eleman sayısı 

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
         public int Length
         {
            get { return items.Length; }
         }


    }
}
