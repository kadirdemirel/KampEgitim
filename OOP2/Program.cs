using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kadir Demirel
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Kadir";
            musteri1.Soyadi = "Demirel";
            musteri1.TcNo = "22222222222";
            musteri1.MusteriNo = "12345";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
