using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği (pythonda yok c# ve java gibi dillerde var)
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35; 
            double dolarBugun = 7.45;

            // şart blokları
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

         
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

       

        }
    }
}
