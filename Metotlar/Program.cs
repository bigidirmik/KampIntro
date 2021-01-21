using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir ürün yelpazesi oluşturalım.

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            // Bu şekilde oluşturduğumuz ürünleri farklı veri tipleri barındırdığı için aşağıdaki diziye koyamayız!

            string[] meyveler = new string[] { };



            // Şimdi doğru yönteme bakalım. Bir ürün yelpazesi oluşturalım.
            // Urun.cs bölümünde oluşturulan Urun class'ımızı kullanabiliriz.

            Urun urun1 = new Urun(); // Urun class'ına urun1 adında yeni bir ürün ekledik ve yanına new Urun(); olduğunu belirtmemiz gerekiyor.
            urun1.Adi = "Elma"; // Urun class'ı içindeki Adi değişkeni ile ismini ekledik.
            urun1.Fiyati = 15;  // Aynı şekilde fiyatını ve açıklamasını da ekledik.
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun(); // Başka bir ürün daha tanımladık.
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 }; // Tıpkı yukarıdaki yanlış örnekteki gibi dizi oluşturabiliriz ve her veri tipini tutabiliriz.

            // Şimdi listeyi yazdıralım.

            // in urunler : urunler dizisinin her bir elemanını tek tek gez demek.
            // küçük harfli urun istediğimiz ismi verebileceğimiz, dizinin elemanlarına bu kod için koyduğumuz takma addır.
            // büyük harfli Urun veri tipidir. var yazsak da kendisi büyük Urun ile eşleşir ancak biz yazarsak hızlı kod olur.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            // Başka bir sayfadayız diye düşünelim. SepetManager'da eklediğimiz Ekle işlemi için.
            Console.WriteLine("------------------Metotlar-------------------");

            // instance - class örneği oluşturma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // her biri farklı sayfa gibi düşünürsek istediğimiz zaman böyle çağırabiliyoruz.
            // bu bize reuseability - tekrar kullanabilme özelliği verdi.
            // artık sepete eklendi (SepetManager içinde) kısmını değiştirince her yerde kolayca değişecek.

            //--------------------------------------------------

            // Neden class yapıyoruz?
            // SepetManager ardından bakacağın kod.
            // Ayrı ayrı yerlerde böyle çağırabiliriz.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 72, 8);
            // Satıcı dedi ki "artık biz ürünün stok adedini de girmek istiyoruz".
            // SepetManager'a dön.
            // Buraya döndük. Şimdi hepsine stok adedi de eklemek zorundayız çünkü kod patladı.
            // Bunları düzeltme için gidip varsayımsal düşünürsek 3 sayfayı ayrıca düzeltmemiz gerekti.

            // Ancak class'a kolayca ekleyebiliriz. Urun.cs'ye public int StokAdedi {get; set;} ekleriz ve her şey stabil çalışmaya devam eder.
            // Çünkü sadece bir alt class ekledik ve isteyince yukarıdaki urun1, urun3 vs. gibi istediğimizin altında çağıracağız.
        }
    }
}


// Metotlar, tekrar tekrar kullanılabilirliği sağlar
// Don't repeat yourself - DRY
// Clean Code / Temiz kod yazma teknikleri
// Best Practice / En iyi uygulama teknikleri