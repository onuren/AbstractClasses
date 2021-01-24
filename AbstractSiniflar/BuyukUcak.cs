using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSiniflar
{
    class BuyukUcak : Ucak
    {
        public override void BiletFiyati()
        {
            Console.WriteLine("Büyük Uçak Bilet Fiyat = 5 TL");
        }
    }
    class KucukUcak : Ucak
    {
        public override void BiletFiyati()
        {
            Console.WriteLine("Küçük Uçak Bilet Fiyat = 3 TL");
        }
    }
}
