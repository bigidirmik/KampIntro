using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditApplicationManager // Kredi Başvuru Manager
    {
        // Method Injection

        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) // hangileri olduğuna dair bilgi yok, soyut halleri var.
        {
            // Bir sürü kod yazarız.
            //
            // Başvuran bilgilereini değerlendir.

            // MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            // Eğer bu şekilde yaparsak tüm başvuruları konut kredisi üzerinden hesaplar. Bu yanlış bir kullanımdır.

            // Başvuruyu kredi çeşitlerinden bağımsız hale getirmek için MakeAnApplication parametre kısmına kredi manager'ını yazdık.
            // Herkesin referansını tutabiliyor.

            creditManager.Calculate();
            // Artık kredilerden bağımsız olarak hesaplar.


            //- loggerService.Log();

            // Hangi loglayıcı seçilmişse onu logla dedik.

            // Birden fazla logger yollamak için önce yukarıda parametredeki ILoggerService kısımını şöle yaparız:
            // List < ILoggerService > loggerServices (dikkat ikincisi yani loggerServices çoğul yaptık.
            // ardından buraya class içine bu foreach döngüsünü ekleriz.

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            // en son olarak program cs içinde başvuru yap kısmının ikinci parametresindeki list değil tek parametre olduğu için patlar.
            // orayı da
            // new List < ILoggerService > { new DatabaseLoggerService() , new SmsLoggerService() } olarak istediklerimizi ekleriz.
            // istersek alternatif şekil olarak parametre içinde new'leyebiliriz. istersek diğerleri gibi üstte newleriz verdiğimiz ismi 2. parametreye yazarız.
        }

        public void GiveCreditPreInformation(List<ICreditManager> krediler) // Kredi ön bilgilendirmesi yap/ver.
                                                                            // ( parametre ile istediği kadar ya da istediği krediyi seçebilir.)
        {
            foreach (ICreditManager kredi in krediler)
            {
                kredi.Calculate(); // Liste yolladık ve program içinde oluşturulan listeye müşterinin seçtiği kredileri tek tek hesaplattık.
            }
        }
    }
}
