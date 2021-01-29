using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Özellik tuttuğumuz yerde Operasyon tutmuyoruz. Operasyon tuttuğumuz yerde de özellik tutmuyoruz.

            // Implementation - Uygulamak

            // OOP2'de verilmek istenen mesaj Base sınıfımız varsa bu Base sınıf Referans tutucudur.


            //-----------------Müşteriler-----------------------//

            // Bilal Dırmık
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Bilal";
            customer1.CustomerSurname = "DIRMIK";
            customer1.CustomerTcNum = "12345678901";

            // Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.CustomerTaxNum = "09876543210";
        }
    }
}
