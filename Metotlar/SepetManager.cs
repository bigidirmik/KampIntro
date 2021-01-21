using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isimlendirme kuralı (Ekle'nin E harfi büyük)
        // syntax - yazım şekilleri
        public void Ekle(Urun urun) // Urun: Tipi, urun: aşağıda kullanmak için verdiğimiz isim. Neyi ekleyeceğimizi söylüyoruz. Bu bir parameteredir.
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        // Bu sektörlerde de çok kullanılır fakat çok yanlış bir kullanımdır!
        // SepetManager'da çağıralım ve neden yanlış görelim. Kodu okuyunca oraya bak. (sepetManager.Ekle2)
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // SepetManager'a tekrardan döndüğünde int stokadedi ekledik. Ve program.cs'sindeki tüm ekle2 kodları patladı.
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}