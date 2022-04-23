using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditService ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditService tasitCreditManager = new TasitCreditManager();
            ICreditService konutCreditManager = new KonutCreditManager();

            ILoggerService fileLoggerManager = new FileLoggerManager();
            ILoggerService smsLoggerManager = new SmsLoggerManager();
            ILoggerService databaseLoggerManager = new DatabaseLoggerManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(ihtiyacCreditManager, new DatabaseLoggerManager()); // icerden de newlenebilir.
            // basvuruManager.BasvuruYap(tasitCreditManager, fileLoggerManager);
            // basvuruManager.BasvuruYap(konutCreditManager, smsLoggerManager);

            // liste olarak kullanmak daha mantikli cunku tek seferde birden fazla yere loglama yapilabilir. Disarda newlemek daha okunakli ve guzel olur.
            basvuruManager.BasvuruYap(new TasitCreditManager(), new List<ILoggerService> { smsLoggerManager, fileLoggerManager }); // disarda newlenmis
            basvuruManager.BasvuruYap(new TasitCreditManager(), new List<ILoggerService> { new DatabaseLoggerManager() }); // icerde newlenmis


            Console.WriteLine("-------------------------");

            // liste olarak kullanmak burda mantikli cunku tek seferde birden fazla kredi bilgilendirmesi yapilabilir.
            List<ICreditService> credits = new List<ICreditService>() { ihtiyacCreditManager, tasitCreditManager, konutCreditManager };
            basvuruManager.KrediOnBilgilendirmesiYap(credits);

            Console.WriteLine("-------------------------");

            // liste olarak loglama servisleri kullandik
            List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerManager, smsLoggerManager, databaseLoggerManager };
            basvuruManager.BasvuruYap(tasitCreditManager, loggers);
        }
    }
}
