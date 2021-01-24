using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //ABSTRACT CLASS
            //Abstract class, Ortak özellikli sınıflara Base(Taban) Class olma görevini üstlenir
            //Örneğin projenizde birden fazla sınıf oluşturup kullanmak istiyorsunuz ve oluşturacağınız sınıflar pekçok yönden ortak özellikleri barındırıyor. işte bu durumlarda Abstract class KULLANILABİLİR
            //Abstract classlar, diğer sınıflara base class olmak için yazılır. Bu nedenle Abstract classlardan NESNE TÜRETİLEMEZ.

            //ABSTRACT METHOD
            //bu metotlar sadece abstract sınıflar içerisinde tanımlanabilirler.
            //Abstract class'ı kalıtan sınıf tarafından overrride edilmek zorundadır.
            //Abstract metotlar gövde bulundurmaz(Interface te olduğu gibi)
            //Private olarak tanımlanamazlar


            #endregion

            #region Ucak

            BuyukUcak bu = new BuyukUcak();
            bu.UcakSirketi = "PEGASUS";
            bu.YolcuKapasitesi = 200;
            bu.BiletFiyati();

            //Ucak u = new Ucak();YAPILAMAZ. Tek amacı base class oluşturmak

            #endregion
        }
    }
}
