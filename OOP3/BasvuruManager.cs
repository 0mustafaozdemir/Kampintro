using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BaşvuruYap(IKrediManager krediManager)
        {
            //Başvuran Bilgilerini Değerlendirme
            //

            krediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

        }
}   }
