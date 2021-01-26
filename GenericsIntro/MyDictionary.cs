using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T>  // T veri tipinde/türünde bir koleksiyon oluşturduk.
    {
        T[] _dic_array;           // T türünde bir dictionary array var dedik.
        T[] _dic_tempArray;       // T türünde bir geçici dictionary array var dedik.

        public MyDictionary()     // bu koleksiyonun uzunluğunu 0 olarak belirledik. zorunlu.
        {
            _dic_array = new T[0];
        }

        public void Add(T item)    // T türünde itemimizi eklemek için
        {
            _dic_tempArray = _dic_array;        //----------------// dizimizi başka bir ref adresi tutan geçici diziye aktararak güverne aldık.
            _dic_array = new T[_dic_array.Length + 1];  //--------// dizimizin uzunluğunu 1 arttırdık.

            for (int i = 0; i < _dic_tempArray.Length; i++)   // geçici dizi uzunluğu kadar çalışan bir for ödngüsü oluşturduk ve
            {
                _dic_array[i] = _dic_tempArray[i];            // geçici dizinin i numaralı elemanı bizim dizimizin i numaralı elemanına aktarıldı.
            }
                                                              // şimdi 1 adet boşluğumuz var
            _dic_array[_dic_array.Length - 1] = item;         // bu boşluğa da bizim itemimizi atıyoruz.

        }

        public T[] Items           // foreach döngüsü için Items isminde değişken belirledik ve sehirler.Items bize dizimizin elemanlarını verecek.
        {
            get { return _dic_array; }
        }

        public int Count                          // Count property'si çağırıldığında bu metot çalışacak ve dizi uzunluğumuzu return edecek.
        {
            get { return _dic_array.Length; }
        }

    }
}
