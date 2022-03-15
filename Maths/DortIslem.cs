using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayi1 + sayi2: " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Sayi1 - sayi2: " + fark);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bolum = sayi1 / sayi2;
            Console.WriteLine("Sayi1 / sayi2: " + bolum);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Sayi1 * sayi2: " + carpim);
        }
    }
}
