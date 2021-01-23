using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        // ctor (2xTab)
        // constructor
        public MyList() 
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            // dizi uzunluğumuz sıfır olarak sabit olduğu için 1 arttıran bir fonk. yazarız, ancak referans numaramız yine değişir ve boş dizimiz olur.
            // bunun için geçiciDizi (tempArray) oluşturuyoruz.
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // elemanları geçici listeden geri aldık.
            }

            items[items.Length - 1] = item;
            // 1 adet boşlukla birlikte elemanlarımızın güvende olduğu listemizin o boşluğuna yani son elemana sonunda item'i aktardık.

        }
    }
}
