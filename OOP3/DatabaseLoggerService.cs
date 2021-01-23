using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService  //veritabanına loglama yapacak süreç
    {
        public void Log()
        {


            Console.WriteLine("Veritabanına Loglandı");

        }
    }


}





