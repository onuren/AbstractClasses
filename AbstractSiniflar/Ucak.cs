using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSiniflar
{
    abstract class Ucak
    {
        public int YolcuKapasitesi { get; set; }
        public string UcakSirketi { get; set; }

        public abstract void BiletFiyati();
    }
}
