using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaces can keep reference number of the implented class.

            //Creating a reference for IKrediManager
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            //Creating references to use ILoggerService.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService); // it could be that way too.
            basvuruManager.BasvuruYap(new EsnasKredisi(), new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService()});
            //List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager }; // calculating more than one credits with List :-)
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            

        }
    }
}
