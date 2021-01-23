using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 483333;
            musteri1.Adi = "Berna";
            musteri1.Soyadi = "Dörtyüz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 190776;
            musteri2.Adi = "Ferhat";
            musteri2.Soyadi = "Teyar";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("------------------------");
            musteriManager.Listele(musteriler);
            Console.WriteLine("------------------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
