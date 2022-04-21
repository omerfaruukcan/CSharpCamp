using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            // Do not repeat yourself - DRY
            // alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.46;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 15.35;
            double dolarBugun = 15.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Oku");
            }
            else
            {
                Console.WriteLine("Esittir Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu burasi");
            }
            else
            {
                Console.WriteLine("Lutfen Giris Yapiniz butonu");
            }
        }
    }
}
