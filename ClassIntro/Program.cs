using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin  Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C++";
            kurs4.egitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;


            //Console.WriteLine(kurs1.kursAdi + " " + kurs1.egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.egitmen);
            }

            //Console.WriteLine("Hello World!");
        }

    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }


    }
}
