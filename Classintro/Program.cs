using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mustafa";
            int yas = 16;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 68;

            kurs kurs3 = new kurs();
            kurs2.kursAdi = "Python";
            kurs2.Egitmen = "Can Demir";
            kurs2.IzlenmeOrani = 68;

            //  Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class kurs
    {

        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
