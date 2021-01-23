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
            ILoggerService fileLogerService = new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };




            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }   
    }

}
