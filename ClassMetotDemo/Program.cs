using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamıza Hoş Geldiniz!");
            Console.WriteLine("####------####");

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Kovalanmaz";
            musteri1.Numara = 05232423343;
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ecem";
            musteri2.Soyadi = "Kaçık";
            musteri2.Numara = 0555555555;
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mahmut";
            musteri3.Soyadi = "Tüptaşır";
            musteri3.Numara = 0553532314;
            
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].Id.ToString()+" " + musteriler[i].Adi + " " + musteriler[i].Soyadi + " " + musteriler[i].Numara.ToString());
            }

            MusteriManager.ekle();
            MusteriManager.sil();

            Console.ReadLine();
        }
    }
}
