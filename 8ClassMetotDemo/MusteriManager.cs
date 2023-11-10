using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Numaralı müşteri" + " " + musteri.Adi + " " + musteri.Soyad + " Listeye eklendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Numaralı müşteri" + " " + musteri.Adi + " " + musteri.Soyad + " Listeden silindi");
        }
    }

}
