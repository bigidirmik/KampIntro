﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            // Burada bu krediye özel hesaplamalar yapıldığını varsayalım.
            //
            //
            //

            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
