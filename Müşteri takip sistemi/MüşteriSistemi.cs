using System;
using System.Collections.Generic;
using System.Text;

namespace Müşteri_takip_sistemi
{
    class MüşteriSistemi
    {
        public void Add(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi : " + musteri.isim + " " + musteri.soyisim);

        }
    }     
         public void Info(Musteri musteri)
         {

        Console.Write("Müşteri Bilgileri : " + "Müşteri Adı : " + musteri.isim + " " + "Müşteri Soyadı : " + musteri.soyisim + " " + "Id:" + musteri.Id + " " + "Telefon:" + " " + musteri.TelefonNumarası);

         }

        public void Delete(Musteri musteri)
        {

        Console.WriteLine("Müşteri Silindi:" + musteri.isim + " " + musteri.soyisim);

        }

}
