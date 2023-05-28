using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utku Çevik
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Utku";
            musteri1.Soyadi = "Çevik";
            musteri1.TcNo = "1254345";

            // UuuuUCorporation
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "UuuUCorporation";
            musteri2.VergiNo = "3434";

            //GERÇEK MÜŞTERİ TUZEL MÜŞTERİ
            //SOLID 
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); // we can send any class based on our inheritance.
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
