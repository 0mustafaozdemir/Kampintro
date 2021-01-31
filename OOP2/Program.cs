using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12312312";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io"; ;
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri


            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

        }
    }
}
