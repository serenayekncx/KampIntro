using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {



            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = "170819";
            musteri1.MusteriAdi = "Lukas";
            musteri1.MusteriSoyadi = "Ekin";


            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = "170719";
            musteri2.MusteriAdi = "Faik";
            musteri2.MusteriSoyadi = "Davulcu";

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = "150519";
            musteri3.MusteriAdi = "Furkan";
            musteri3.MusteriSoyadi = "Çınar";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.MusteriId + " - " + Musteri.MusteriAdi + " - " + Musteri.MusteriSoyadi);
            }


            Console.WriteLine("-----metotlar-----");

            Musterimanagerr musteriManager = new Musterimanagerr();

            musteriManager.Kaydet(musteri1);

            musteriManager.Kaydet(musteri2);

            musteriManager.Kaydet(musteri3);



        }







        public class Musteri

        {
            public string MusteriId { get; set; }
            public string MusteriAdi { get; set; }
            public string MusteriSoyadi { get; set; }

        }









































































    }
}

