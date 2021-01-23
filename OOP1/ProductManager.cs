using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }







        //----------------------------------------Örnekli Anlatım void nedir------------------------------------------------------

        // void : emir kipidir. işlem sonucu ile ilgili ekstra bir bilgiye ihtiyacımız yoksa böyle tanımlayabiliriz.

        // farkı daha iyi anlamak için örnek
        // public int Topla(int sayi1,int sayi2)
        // {
        //     return sayi1 + sayi2;
        // }

        // burada da Topla2 işlemi yapıyor, console da ekrana yazdırıyor (program.cs bak 30. satır)
        // public void Topla2(int sayi1, int sayi2)
        // {
        //     Console.WriteLine(sayi1 + sayi2);
        // }



        //---------------------------------------Örnekli Anlatım referans-------------------------------------------------------

        // bu şekilde manager service gibi isimlendirme olan classlar görürsek
        // bunlar ekleme silme listeleme filtreleme arama gibi operasyonları içeriyor demektir

        // neden Product türünde bir şey ver diyoruz?
        // çünkü 50 tane parametre geçmek yerine hepsini içeren bir product ver diyoruz
        // encapsulation yani
        // kod "sen bana product1 isminde bir şey göndereceksin ben onu product isminde tutuyor olacağım" diyor

        // public void Add(Product product)    // Add(string isim) aynı şey. bana string türünde isim yaz diyoruz.
        // {
        //    product.ProductName = "Kamera";       
        // }

        // Masa iken kamera olarak değiştirdik. Program.cs kısmına yazdıralım. Sonuç ne olur?
        // Bu referans tipi olduğu için kamera yazması için burada console'a yazdırmamız gerekiyor çünkü kamera buraya özel.
        // tahminim sonucun Masa olduğu yönünde



        // bu kısımı anlamak için bir örnek

        // public void BirSeyYap(int sayi)
        // {
        //    sayi = 99;   // sayıyı 99 olarak değiştirdik.
        // }


    }
}
