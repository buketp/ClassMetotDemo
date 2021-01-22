using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listeleniyor.. "+musteri.Adi);
        }

        public void Ekle(string musteriAdi, string musteriSoyadi)
        {
            Console.WriteLine("Ekleniyor.. "+musteriAdi);
        }

        public void Sil(int musteriId)
        {
            Console.WriteLine("Siliniyor.. "+musteriId);
        }

    }
}
