using System;

namespace Ders2_Konu1
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety : tip güvenliği (yoğundur)

            //---------------------------------------------------------

            // Tek tek yazarsak "Kategori" bölümünü de tek tek düzeltmek zorunda kalırız. Bu yüzden yanlış bir uygulamadır.
            // Do not repeat yourself - Kendini tekrarlama!

            // Console.Writeline("Kategori Adı");
            // Console.Writeline("Kategori Adı");
            // Console.Writeline("Kategori Adı");
            // Console.Writeline("Kategori Adı");

            // Bunun yerine:
            string kategoriEtiketi = "Kategori Adı";
            // kategoriEtiketi bir değer tutucudur - alias

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            // Şimdi tırnak içini "Kategori" değiştirince her yerde değişir.

            //---------------------------------------------------------

            int ogrenciSayisi = 32000; // int: sayı veri tipidir. Çok fazla basamak olursa altını kırmızı çizer ve tanımaz.

            //---------------------------------------------------------

            double dolarDun = 7.55; // double: float ile aynıdır. Ondalıklı sayılar içindir.
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Azalmış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar Artmış");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi");
            }
            // dolar eşit olduğu için else komutu çalışır.

            //---------------------------------------------------------

            bool sistemegirişYapmisMi = false; // boolean ile aynıdır. false kısmı veri kaynağından gelir. yani =girisYapmismiBirBak(); şeklinde.

            if (sistemegirişYapmisMi == true)
            {
                Console.WriteLine("Kullanıcının profil fotoğrafı");
            }
            else
            {
                Console.WriteLine("Lütfen giriş yapınız"); // veri kaynağından gelen false olduğu için if çalışmaz ve o zaman burası çalışır.
            }

            //---------------------------------------------------------

        }
    }
}
