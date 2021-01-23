using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] isimler = new string[] {"Bilal","Hikmet","Sevgi"};
            // Console.WriteLine(isimler[0]);
            // Console.WriteLine(isimler[1]);
            // Console.WriteLine(isimler[2]);
            // isimler[3] = "Nusret";
            // Console.WriteLine(isimler[3]);
            // Bu satır çalışmayacak ve tüm sistem çökecektir. Array sınırları dışında hatası.
            // isimler = new string[5]; yaparsak ve ardından eklersek evet çalışır. Ancak:
            // 0 numaralı elemanı tekrar çağırınca boş olarak gelir.
            // Çünkü biz 5 elemanlı boş bir yeni array oluşturduk. ilk array başka bir referans adres idi. yeni array başka bir adres. çünkü "new" yeni heap.
            // yani dizleri genişletemeyiz. Bu yüzden koleksiyonlar C# a dahil edildi. genellikle array kullanılmaz koleksiyon kullanılır. aşağıda.

            // !!!! Lİst yazıp ampulden using System.Collections.Generic ekle diyoruz. !!!!
            // ekleme yöntemi 1
            List<string> isimler2 = new List<string>();
            isimler2.Add("Bilal","Hikmet");
            // ekleme yöntemi 2
            List<string> isimler3 = new List<string>() { "Bilal", "Hikmet", "Sevgi" };

            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            isimler3.Add("Nusret");
            Console.WriteLine(isimler3[3]);
            Console.WriteLine(isimler3[0]);
            // şimdi ise değerleri kaybetmedik ve listeye eleman da ekledik.

            
        }
    }
}
