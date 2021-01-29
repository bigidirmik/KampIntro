using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager // Kırmızı altı çizili iken ampulden "Implement Interface" yaparız ve alttaki kodları kendi ekler.
    {
        public void Calculate()
        {
            // Burada bu krediye özel hesaplamalar yapıldığını varsayalım.
            //
            //
            //

            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
