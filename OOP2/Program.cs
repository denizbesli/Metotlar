using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Deniz";
            musteri1.Soyadi = "Besli";
            musteri1.TcNo = "22222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12334";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "112442516";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            
            //Gercek Müsteri -Tuzel Musteri
        }
    }
}
