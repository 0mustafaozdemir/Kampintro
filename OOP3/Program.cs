using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager İhtiyacKrediManager  = new İhtiyacKrediManager();
            IKrediManager TaşıtKrediManager  = new TaşıtKrediManager();
            IKrediManager KonutKredisiManager  = new KonutKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BaşvuruYap(İhtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
