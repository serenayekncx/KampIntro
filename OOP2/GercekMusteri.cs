using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //Indıvıdual 

    //inheritance - miras gercek musteri:musteri(tuzel musteri bir musteridir)
    class GercekMusteri :Musteri
    {

        //prop tanımladığımız class burada operasyon tutulmaz
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
