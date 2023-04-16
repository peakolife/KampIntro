using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Mersin");
            sehirler2.Add("Adana");
            sehirler2.Add("Adana");
            Console.WriteLine(sehirler2.Count);
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(175, "utku");
            ogrenci.Add(365, "hüseyin");
            ogrenci.Add(765, "çevik");
            Console.Write("öğrenci numarası giriniz:");
            int no = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(ogrenci[no]);
            }
            catch
            {
                Console.WriteLine("öğrenci bulunamadı");
            }

        }
        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;
            public MyList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;

            }
            public int Count { get { return _array.Length; } }
        }
    }
}
