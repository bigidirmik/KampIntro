using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer: Customer // Bu ve Gerçek Müşteri Entity yani varlıktır. Bu yüzden Operasyon barındıramaz.
    {
        // LegalEntity de denebilir. Tüzel Müşteri class'ıdır.

        public string CustomerTaxNum { get; set; }
        public string CompanyName { get; set; }

        // Eğer matematiksel bir işlem yaptırmayacaksak TC numarası, vergi numarası gibi sayıları string olarak tutmak daha iyidir.

        // Gerçek Müşteri ve Tüzel Müşteri birbirine benziyor diye birbirlerinin yerine kullanmak hatalıdır.
        // Yani burada Company Name olan kısımın diğerleri ile birlikte olması yanlıştır. SOLID kuralının L harfi.
        // Bu hatayı yapmamak için Gerçek Müşteri ve Tüzel Müşteri olarak iki ayrı class oluşturmamız gereklidir.
    }
}
