using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(ICreditService creditManager, List<ILoggerService> loggerService)
        {
            // Basvuran bilgilerini degerlendirme
            // ....
            creditManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditService> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
