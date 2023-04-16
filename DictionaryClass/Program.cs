using System;
using System.Collections.Generic;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> ogrList = new MyDictionary<string, int>();
            ogrList.Add("utku", 1);
            ogrList.Add("ahmet", 2);
            foreach (var item in ogrList)
            {
                Console.WriteLine(item.Value + " " + item.Key);

            }
        }
    }
}
