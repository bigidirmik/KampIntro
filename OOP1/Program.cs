using System;

namespace OOP1
{
    class Program  // intentional kodlama tekniği, ihtiyaçları önce sanki varmış gibi kodluyoruz sonra onları dolduruyoruz. (niyet güdümlü kodlama)
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa"; // 101 nolu bellek adresinde
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // böyle de oluşturabiliriz
            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};


            // genelde classların yanındaki değişkeni camel case versiyonu ile isimlendiririz
            // C#, Java'da Case Sensitive vardır (büyük küçük harf duyarlılığı)
            // PascalCase  //camelCase
            ProductManager productManager = new ProductManager();
            //          Stack               //       Heap
            // referans tip oluşturabilmek için, heap'te oluşturabilmek için new'leriz
            
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);





            //----------------------------------------Örnekli Anlatım void nedir------------------------------------------------------

            // productManager.Topla2(3, 6); // topladı ve 9 oldu ProductManager kısmında ekrana yazdırdı.

            // Peki neden return'e ihtiyaç var. Cevap basit sonucu başka bir yerde de kulllanabilmek için. void ile yap bitir dedik ve bitti. kullanamıyoruz.

            // int toplamaSonucu = productManager.Topla(3, 6);
            // Console.WriteLine(toplamaSonucu*2);

            // burada ise int veri tipinde toplamaSonucu adında bir değişkene aktarabildik (void'e aktaramayız)
            // böylece değişkeni console'da çağırabildik.



            //---------------------------------------Örnekli Anlatım referans-------------------------------------------------------

            // productManager.Add(product1);            // buraya 101 nolu bellek adresi yollanıyor
            // Console.WriteLine(product1.ProductName);

            // cevabım Masa idi
            // yanlış, ProductName değeri Kamera oldu. Neden?
            // diziler classlar, abstract class, interface referans tip
            // ref tiplerde her şey, atamalar referansın numarası ile yapılır ( yani bellekteki adresi ile)
            // 101 nolu bellek adresini ProductManager aldı ve Name'ini Kamera olarak değiştirdi
            // 101 nolu ProductName yani kamerayı ekrana yazdırdık


            // ProductManager kısmındaki örnekle alakalı kısım

            // int sayi = 100;
            // productManager.BirSeyYap(sayi);
            // Console.WriteLine(sayi);

            // ProductManager'a gidip sayıyı 99 ile değiştirelim ve ekrana yazdıralım. sayı sonucunu ne yazacaktır?
            // tahminim sayı 99 olmuştur. çünkü sayı üstteki tanımda sabit kalmıyor olmalı. çünkü referans tipi değil.
            // yanlış, sayı'nın değeri 100 olarak kalmış. Neden?
            // sayısal olanlar int, double, bool değer tip
            // diğer bölüm bağımsız, yani burada sayıya 100 değerini verdik ve buradaki console ekranına sayı kelimesinden tamamen kopup 100 olarak geçti
            // ancak referans tiplerde şöyle - 29. satıra bak






        }
    }
}
