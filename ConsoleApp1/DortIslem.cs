using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+ toplam);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + fark);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpım = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpım);
        }
        public void bolme(int sayi1, int sayi2)
        {
            int bolumu = sayi1 / sayi2;
            Console.WriteLine("Sonuç : "+ bolumu);
        }

    }
}
