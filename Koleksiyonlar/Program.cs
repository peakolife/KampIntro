using System;
using System.Collections.Generic; // koleksiyonları kullanmamız için System.Collections.Generic kütüphanesini eklememiz lazım

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "a", "b", "c", "d" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("e");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

        }
    }
}
