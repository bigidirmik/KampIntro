using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] _myList_array;

        // ctor (2xTab)
        // constructor
        public MyList() 
        {
            _myList_array = new T[0];
        }

        public void Add(T item)
        {
            // dizi uzunluğumuz sıfır olarak sabit olduğu için 1 arttıran bir fonk. yazarız, ancak referans numaramız yine değişir ve boş dizimiz olur.
            // bunun için geçiciDizi (tempArray) oluşturuyoruz.

            T[] tempArray = _myList_array;   // elemanlar geçici diziye aktarıldı ve güvende.
            _myList_array = new T[_myList_array.Length+1]; // dizimizi 1 eleman arttırdık.

            for (int i = 0; i < tempArray.Length; i++)  // geçici liste uzunluğu kadar çalış dedik.
            {
                _myList_array[i] = tempArray[i]; // elemanları geçici listeden geri aldık.
            }

            _myList_array[_myList_array.Length - 1] = item;  // oluşan boşluğa bizim ekleyeceğimiz itemi aktarmasını söyleyelim.
            // 1 adet boşlukla birlikte elemanlarımızın güvende olduğu listemizin o boşluğuna yani son elemana sonunda item'i aktardık.

        }

        public int Length // uzunluk komutunu çağırdığımızda bu satır çalışır ve uzunluğu hesaplar.
        {
            get { return _myList_array.Length; }
        }

        public T[] Items
        {
            get { return _myList_array; }
        }
    }
}
