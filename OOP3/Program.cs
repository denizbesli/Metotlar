using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtitacKrediManager = new İhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtitacKrediManager, new DatabaseLoggerService());

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtitacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
