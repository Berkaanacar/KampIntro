using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach ( Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("------------------------Metotlar------------------------");
            //encapsulation - Kapsülleme / ayrı ayrı yazıcağın şeyi bir kapsülün içine kolayca yazma yöntemi
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 25);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 50);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 45);
        }

    }
}
