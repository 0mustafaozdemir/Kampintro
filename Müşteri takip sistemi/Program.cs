using System;

namespace Müşteri_takip_sistemi
{
    class MusteriTakip
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.İsim = "Mustafa";
            musteri1.Soyisim = "Özdemir";
            musteri1.Id = 311123321;
            musteri1.TelefonNumarasi = "055511133323";


            Musteri musteri2 = new Musteri(); 

            musteri2.İsim = "Mahmut";
            musteri2.Soyisim = "Özdemir";
            musteri2.Id = 3333123321;
            musteri2.TelefonNumarası = "099911133323";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler) 
            {
                Console.WriteLine(musteri.İsim);
                Console.WriteLine(musteri.Soyisim);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.TelefonNumarasi);
            }

             
            
        }
    }
}
