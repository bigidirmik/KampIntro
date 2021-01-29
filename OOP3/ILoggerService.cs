using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService
    {
        // interface olduğu için sadece imza koyabiliriz. İçi dolu olamaz.

        // Loglama - kim ne zaman hangi operasyonu çağırdı; sistemde olan hareketlerin dökümüdür. Veri tabanı, dosya, sms, mail olarak tutulabilir.

        // Mesela Log için de interface kullanılır. Farklı tutma yolları için.

        void Log();
    }
}
