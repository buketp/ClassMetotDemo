using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("napıcam hiçbi şe bilmiyom");

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Buket";
            musteri2.Soyadi = "Polat";
            musteri2.Id = 456;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Mehmet";
            musteri3.Id = 789;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            musteriManager.Ekle("Ali","A");
            musteriManager.Ekle("Veli","B");

            musteriManager.Sil(789);

        }
    }
}
