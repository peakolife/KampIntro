using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Ekşi sulu elma";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Tatlı Armut";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 100;
            urun3.Aciklama = "Sulu tatlı kırmızı karpuz";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("##################");
            }
        }
    }
}
