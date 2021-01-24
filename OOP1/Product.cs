using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    //CRUD Operation
    class Product
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }
        //Ürün İsmi
        public String ProductName { get; set; }
        //Ürünün Birim Fiyatı
        public double UnitPrice { get; set; }
        //Stok Adeti
        public int UnitsInStock { get; set; }

    }

}
