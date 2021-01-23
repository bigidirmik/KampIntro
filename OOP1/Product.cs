using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // snippet (2xTab), intellicense
    class Product // Entity / varlık isimleri verilir genelde
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // eklemek okumak güncellemek silmek gibi eylemlere CRUD operasyonları denir

    }
}
