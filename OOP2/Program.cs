using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 8;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Serenay";
            musteri1.Soyadi = "Ekinci";
            musteri1.TcNo = "1232232";


            //KODLAMA.İO

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 4;
            musteri2.MusteriNo = "23242";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "454546474";

            //Gerçek - Tüzel
            //SOLID 

            
            //bir yerde new görürsen bunu 'bu bellekte bir ref nosu' olarak oku.
            //Musteri dosyası hem gerçek hem tuzel musterinin referansını tutabiliyor

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);




        }
    }
}
