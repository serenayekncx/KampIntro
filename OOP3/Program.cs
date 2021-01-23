using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            TasitKrediManager tasitKrediManager1 = new TasitKrediManager();
            IKrediManager tasitKrediManager = tasitKrediManager1;
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };




            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }   
    }

}
