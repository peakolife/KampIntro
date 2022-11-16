using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 1;
            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.KursAdi = "C++";
            kurs2.IzlenmeOrani = 1;
            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.KursAdi = "Java";
            kurs3.IzlenmeOrani = 1;
            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.IzlenmeOrani.ToString() + " " + kurs1.KursAdi);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
    class GiyimUrun
    {
        public string Adi { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Olcu { get; set; }
        public int Yildiz { get; set; }
        public int Indırım { get; set; }

    }
}
