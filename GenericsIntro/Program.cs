using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Bilal");
            Console.WriteLine(isimler.Length);

            isimler.Add("Hikmet");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            //-------------------------MY DICTIONARY-----------------------------//

            MyDictionary<string> sehirler = new MyDictionary<string>();  // sehirler adında string türü MyDictionary classından gerekli kodları alacak yeni bir MyDictionary dizisi
            sehirler.Add("Bursa");
            sehirler.Add("İzmir");
            sehirler.Add("Ankara");  // sehirler isimli diziye Add komutu ile ekledik.
            sehirler.Add("İstanbul");

            foreach (string sehir in sehirler.Items)  // MyDictionary classından Items bölümündeki komut ile dizi elemanlarını çektik ve bunların her birine sehir takma ismi verdik.
            {
                Console.WriteLine(sehir);  // her birini yazdırmasını istedik. listedeki bu takma isimdeki her itemi yazdıracak.
            }

            Console.WriteLine(sehirler.Count);  // MyDictionary classındaki Count bölümünden dizi uzunluğu komutunu çağırdık.
        }
    }
}
