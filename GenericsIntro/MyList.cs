using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)// yeni isim eklediğimizde bir arttırdığımızda ilk değer uçar o yüzden alta bak şimdi.
        {                                                                            
            T[] tempArray = items;// temparray geçici dizi  ilk referansı tutar      |
            items = new T[items.Length+1];// string listesini 1 tane daha arttırdık. |
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];// daha önceki tempArrayın tuttuğu verileri items a veriyorsun.
            }

            items[items.Length - 1] = item;






        }
    }
}
