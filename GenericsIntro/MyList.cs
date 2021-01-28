using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //dizi
        //constructor: Bir class newlendiğinde çalışan bloga denir.
        public MyList()
        {
            items = new T[0];  
        }
        public void Add (T item)
        {
            T[] tempArray = items; //Referans numarası newlediğimiz zaman silinmesin diye tempArray (geçiçidizi) değeri geçicidiziye tanımlarız.
            items = new T[items.Length+1]; //1 arttırma işlemi
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
