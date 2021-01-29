using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager // Kötü bir yazılımcının yapacağı ise şudur. Bunu interfae yerine class yapar ve:
    {
        void Calculate(); // Burada, hesapla kısmı içerisinde parametre int krediTuru yazar. 
                          // Altında da if kredi türü şu ise şunu yap, if kredi türü şu ise bunu yap der.
                          // 300 çeşit kredi olduğunu varsayınca bunu yapmak çok mantıksız olur.
                          // O yüzden interface yaparız. Her kredi için class oluşturur ve bu interface içindeki hesapla kısmını implement ederiz.
                          // Her birinin kendi hesaplama metodu olur.
        void DoSomething();
    }
}
