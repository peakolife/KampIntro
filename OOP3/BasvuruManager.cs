using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // applicant information appraisal.
            krediManager.Hesapla(); // with krediManager we can keep and calculate every kind of kredi.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
             
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
