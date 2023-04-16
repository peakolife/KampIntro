using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri mustericik)
        {
            Console.WriteLine(mustericik.Adi + " başarıyla eklendi.!");
        }
        public void sil(Musteri mustericik)
        {
            Console.WriteLine(mustericik.Adi + " başarıyla silindi.");
        }
        
    }
}
