using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        // Property - özellik (Bu yüzden oluştururken prop yazarak 2xTab yaparız.)
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
        // program.cs'de ekle2 altında bahsettiğimiz yeni eklediğimiz kısım.
        // Sadece buraya StokAdedi ekledik ve hiçbir şey bozulmadı, buna encapsulation deniyor. (kapsulleme)
        // Normalde ayrı ayrı yazacağımız ve düzensiz olacak bir yapıyı bir düzenin-kapsülün içine sokuyoruz.
    }
}
