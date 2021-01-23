using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //Coorporate - Tüzel (Legal Entity)

    //inheritance - miras tuzel musteri:musteri(tuzel musteri bir musteridir)
    class TuzelMusteri:Musteri
    {

        //prop tanımladığımız class burada operasyon tutulmaz
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
