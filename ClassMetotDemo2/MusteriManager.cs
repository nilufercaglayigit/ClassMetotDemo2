using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. " + musteri.Adi + " " + musteri.Soyadi + " kişisi eklendi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);

            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adlı kişi silindi.");
        }
    }
}
