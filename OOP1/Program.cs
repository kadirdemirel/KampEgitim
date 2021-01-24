using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product()
            {
                ID = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Sandalye",
                UnitPrice = 650
            };

            Product product3 = new Product
            {
                ID = 3,
                CategoryId=4,
                UnitPrice=700,
                UnitsInStock=50,
                ProductName="Hırka"

            };
            //PascalCase    //camelCase 
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product2);
            Console.WriteLine(product2.ProductName);

                productManager.Topla2(3, 6);

            int toplamSonucu = productManager.Topla(3, 7);
            Console.WriteLine(toplamSonucu * 2);

            //int,double,bool .... değer tip
            //diziler,class,abstract class,interface .... referans tip
            //ref out
            
        }
    }
}
