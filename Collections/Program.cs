using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string[] isimler = new string[] {"Murat","Serenay","Lukas","Faik" };
        //    Console.WriteLine(isimler[0]);
        //    Console.WriteLine(isimler[1]);
        //    Console.WriteLine(isimler[2]);
        //    Console.WriteLine(isimler[3]);

        //    isimler = new string[5]; // --- yeni bi array atadın artık en alttaki cw'u 
        //    //okumaz diziler genişlemez arrayin sınırları baştan belli.
        //    isimler[4] = "İlker";
        //    Console.WriteLine(isimler[4]);
        //    Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Murat", "Serenay", "Lukas", "Faik" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);
            
            
           
        
       
}   }   }
