using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisi : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı.");
        }
    }
}
