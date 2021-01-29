using System;

namespace OOP3
{
    // Bu class FileLoggerService class'ı altına eklendikten sonra ampul ile move type ile yeni dosyaya taşındı. Kısayoldur.

    class SmsLoggerService : ILoggerService // bu parentı ekleyerek referans avantajından yararlandık.
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı.");
        }
    }
}
