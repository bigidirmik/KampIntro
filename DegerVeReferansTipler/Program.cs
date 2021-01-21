using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 kaç yazdırır ?
            // benim tahminim sayi1 = 30 , sayi2 = 65 çünkü sayi2 sayi1'e eşitlendikten sonra değiştirildi bu yüzden sayi1'e 65'in etkisi olmaz.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] elemanı kaç olurdu ?
            // benim tahminim sayilar1[0] = 100 aynı şekilde 999 sonradan eşitlendi artık etkisi olmaz diye tahmin ettim.

            // 1. cevap 30 doğru mantık yürüttüm
            // 2. cevap ise yanlış. cevap 999. demek ki aynı mantık işlemiyor.

            // Hocanın açıklaması

            // int, decimal, float, double, bool = bunlar değer tip.
            // fakat
            // array, class, interface = bunlar referans tip. int array olması farketmiyor.
            // sonuçlarının değişik olmasının sebebi bu iki tip farkı.

            // bellekte stack ve heap diye iki alan vardır.

            // bir değişken tanımlayınca değer tip olanlar tamamen stack'te gerçekleşir.
            // değer tiplerde şöyle okunur
            // sayi1=10
            // sayi2=30
            // yani sayı 1'in değeri eşittir 10. sayı 2'nin değeri eşittir 30. şeklinde okuruz.
            // 13. satır şöyle okunur. sayı 1'in değeri eşittir sayı 2'nin değeri. ve sayı 2 ile irtibatını değeri kopyaladıktan sonra keser.
            // adı üstünde değer tip. değeri kopyalar ve biter.

            // 2. soruda şöyledir
            // sayilar1'i stack kısmına yazar
            // fakat = new dediğimiz anda heap kısmında [10, 20, 30] diye bir alan oluşturur.
            // aralarındaki bağlantı ise sayilar1'in adresi olan 101 (örneğin) ile sağlanıyor.
            // stack alanında 101/sayilar1 heap alanındaki şuna işaret ediyor 101/[10, 20, 30]
            // sonra sayilar2 tanımladık ve new'ledik.
            // stack alanında 102/sayilar2 - ve işaret ettiği heap alanındaki 102/[100, 200, 300] oluştu.
            // buraya kadar her şey normal. burdan sonra olay kopuyor.
            // 20. satır olan burası da şöyle okunuyor.
            // sayilar1'in referans numarası eşittir sayilar2'nin referan numarası
            // yani artık adresi 102 oluyor ve 102/sayilar1 olduğu için heap kısmında 102/[100, 200, 300] kısmını işaret ediyor.
            // (buraya kadar doğru tahmin etmiştim, fakat neden 999 oldu bakalım)
            // ardından sayilar2'nin 0'ıncı elemanını 999'a eşitledik. 21. satır.
            // böylece stack'te 102/sayilar2 - heap'te 102/[999, 200, 300] oldu.
            // soru ise sayilar1'in [0]'ıncı elemanı idi.
            // stack 102/sayilar1 - heap 102/[999, 200, 300] kısmını çağırdığı için 0'ıncı eleman 999 çıkar.
            // buna C gibi dillerde pointer deniyor.
            // 101/[10, 20, 30] - bunu tutan kimse yoktur bu yüzden biraz sonra .Net'in garbage collector'ı (çöp toplayıcısı) gelip,
            // "seni tutan kimse yok bu yüzden ben seni bellekten atıyorum" diyecektir.



        }
    }
}
