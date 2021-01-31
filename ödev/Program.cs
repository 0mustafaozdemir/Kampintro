using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class");

            urun urun1 = new urun();
            urun1.urunAdi = "Bilgisayar";
            urun1.urunFiyati = "7000";

            urun urun2 = new urun();
            urun2.urunAdi = "Telefon";
            urun2.urunFiyati = "4500";

            urun[] urunler = new urun[] { urun1, urun2 };


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " : " + urun.urunFiyati);
            }

            for (int i = 0; 1 < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }
        }

       


           


    }
    class urun
    {
        public string urunAdi { get; set; }
        public string urunFiyati { get; set; }
    }


}
