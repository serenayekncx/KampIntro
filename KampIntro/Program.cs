using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Knedini tekrarlama
            //değer tutucu,alias


            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi =  false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) ;
            {
                Console.WriteLine("Azalış Botunu");

            }

            else if (dolarDun < dolarBugun) ;
            {

                Console.WriteLine("artış butonu");

            } 

            else

            {
                Console.WriteLine("değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {

                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap botunu");


            }

            Console.WriteLine(kategoriEtiketi);


















        }
    }
}
