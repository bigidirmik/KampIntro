using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------INTERFACES-----------//----------POLIMORFISM-----------//

            // Yıldızlı not - Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız!

            // Interface'ler de o interface'i implemente eden class'ı ve yani referansını tutabiliyorlar.

            // Loglama - kim ne zaman hangi operasyonu çağırdı; sistemde olan hareketlerin dökümüdür. Veri tabanı, dosya, sms, mail olarak tutulabilir.

            // Mesela Log için de interface kullanılır. Farklı tutma yolları için.




            //- PersonalFinanceCreditManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            //- ihtiyacKrediManager.Calculate();

            //- TransportCreditManager tasitKrediManager = new TransportCreditManager();
            //- tasitKrediManager.Calculate();

            //- MortgageLoanManager konutKrediManager = new MortgageLoanManager();
            //- konutKrediManager.Calculate();

            // Bu şekilde ekrana kredilerin içindeki kodu yazdıracaktır.

            // Ancak önemli nokta şudur ki:

            //- ICreditManager ihtiyacKredisiManager = new PersonalFinanceCreditManager();
            //- ihtiyacKredisiManager.Calculate();

            // Hepsi interface'imizi kullanarak da aynen çalışabilir.
            //
            //

            //---------------------CreditApplicationManager düzenledikten sonra ise şunu yaptık----------------------//

            ICreditManager konutKrediManager = new MortgageLoanManager();
            ICreditManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            ICreditManager tasitKrediManager = new TransportCreditManager();

            // Bunların ekrandaki açılır kutu ve seçenekleri olduğunu düşünelim.


            ILoggerService databaseLoggerService = new DatabaseLoggerService(); // bunları da oluşturduğumuz için sonradan newledik.
            ILoggerService fileLoggerService = new FileLoggerService(); // 
            ILoggerService smsLoggerService = new SmsLoggerService(); // bunlar üç loglama alternatifi

            // Birden fazla loglama için liste, şimdi aşağıda başvuru yerinin ikinci parametresi loggers yapmak yeterli olacak.
            List<ILoggerService> loggers = new List<ILoggerService> { fileLoggerService, databaseLoggerService, smsLoggerService }; // neleri istersek ekleriz.


            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            creditApplicationManager.MakeAnApplication(tasitKrediManager, loggers); // databaseLogger ve fileLogger oluşturunca istedi, parametreye ekledik

            // Yukarıda ise kullanıcının kredilerden birini seçtiğini, bu seçim ile de üstteki parametreye o seçimin eklendiğini düşünelim.
            // Bu kod kredi başvuru class'ına gider ve orada da taşıt kredisi atandığı için taşıt kredisi class'ının hesaplaması çalışır.
            // Bu yüzden de ekrana sadece Taşıt kredisi ödeme planı hesaplandı yazar.

            // Soyutlama yani bu OOP3 Projesinde anlatılanlar son derece önemlidir. İşe kabul ettirecek bilgilerdir.


            // Kredi ön bilgilendirmesi yap kısmından sonra buraya geldik. Orada parametre içine sayısı belirsiz olduğu için List yapmıştık.
            List<ICreditManager> krediler = new List<ICreditManager>() { tasitKrediManager, ihtiyacKrediManager}; // süslü parantezlerin içi: müşterinin bilgi almak istediği kredilerden seçtiğini varsayalım.
            //- creditApplicationManager.GiveCreditPreInformation(krediler); // krediönbilgilendirmesiyap(kredilerden) demek.

            // yeni kredi oluşturmamız istendi diyelim, esnaf kredisi gibi. SOLID'in O harfi (sisteme yeni özellik eklendiğinde sistem bozulmaz)
            // yeni class'ı ekleriz hesapla kısmını simüle ederiz.
            // Başvuru kodunun (yukarda) ilk parametresini new EsnafKredisiManager() yaparız. ( ya da orada new'lemek yerine diğerleri gibi üzerinde instence yaparız.)

            // ayın şey loglama için de geçerli. artık sms de yollayalım dedik. smsLoggerService class'ı oluşturduk.
            // :ILoggerService ekleyip implement edip public void Log() { cw( "sms yollandı" ) } deriz.
            // Program cs kısmında başvuru ikinci parametresini new smsLoggerService() yapar ya da diğerleri gibi üstte new'leriz. (alternatif yollardır)

            // Bu yaptıklarımız Polimorfizmdir.

        }
    }
}
