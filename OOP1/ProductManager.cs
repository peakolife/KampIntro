using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Ürünü Başarıyla Eklendi!");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Ürünü Başarıyla Güncellendi!");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + "Ürünü Başarıyla Silindi!");
        }
        public int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
    }
}
