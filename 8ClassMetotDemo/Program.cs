namespace _8ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellooo Kübra Bankaya Hoşgeldiniz:) ");
            Console.WriteLine("**********************************");
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Kübra";
            musteri1.Soyad = "Yalçın";
            musteri1.KrediNot = 840;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Yusuf";
            musteri2.Soyad = "Söylemez";
            musteri2.KrediNot = 900;



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)

            {
                Console.WriteLine("MUSTERİ ID: " + musteri.Id);
                Console.WriteLine("Musteri Adi: " + musteri.Adi);
                Console.WriteLine("Musteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Musteri Kredi Notu: " + musteri.KrediNot);
                Console.WriteLine("************");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);









        }
    }
}