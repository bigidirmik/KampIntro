using System;

namespace OOP3
{
    // Bu class DatabaseLoggerService class'ı altına eklendikten sonra ampul ile move type ile yeni dosyaya taşındı. Kısayoldur.
    class FileLoggerService : ILoggerService // bu parentı ekleyerek referans avantajından yararlandık.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
