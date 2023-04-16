using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //we will bring it via foreign key.
            product1.ProductName = "Sandalye";  
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            ProductManager prdtmng = new ProductManager();  
            Console.WriteLine(prdtmng.Topla(7,7,7,7,7,7,8));

            Console.ReadLine();
        }
    }
}
