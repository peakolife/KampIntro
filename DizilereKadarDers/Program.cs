using System;

namespace DizilereKadarDers
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan sayı alalım ve girilen sayılarla ilgili bir karar yapısı oluşturalım.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int Sayi1Gir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int Sayi2Gir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Girilen Sayı: " + Sayi1Gir);
            Console.WriteLine("2. Girilen Sayı: " + Sayi2Gir);
            Console.Clear();
            if(Sayi1Gir > Sayi2Gir)
            {
                Console.WriteLine("1.Girdiğiniz sayı 2.girdiğiniz sayıdan büyüktür.");
            }
            else if(Sayi1Gir<Sayi2Gir)
            {
                Console.WriteLine("2.Girdiğiniz sayı ilk girdiğiniz sayıdan büyüktür.");
            }
            else if(Sayi1Gir == Sayi2Gir)
            {
                Console.WriteLine("Girdiğiniz sayılar eşittir.");
            }
            else
            {
                Console.WriteLine("Yanlış bir değer girdiniz.");
            }

        }
    }
}
