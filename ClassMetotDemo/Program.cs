using System.Collections;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList musteriler = new ArrayList();

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "berkay";
            musteri1.Soyad = "alparslan";
            musteri1.Tc = "12345678978";
            musteri1.EMail = "berkay@gmail.com";
            musteri1.Sifre = "123456";
            musteri1.HesapNo = "1234 4567 1232 4567 4567";
            musteri1.Bakiye = 100000000;
            musteri1.DogumTarihi = DateTime.Now;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "ebubekir";
            musteri2.Soyad = "ışık";
            musteri2.Tc = "12345678987";
            musteri2.EMail = "ebu@gmail.com";
            musteri2.Sifre = "123456";
            musteri2.HesapNo = "1235 4567 1232 4567 4567";
            musteri2.Bakiye = 1000000;
            musteri2.DogumTarihi = DateTime.Now;

            MusteriManager _musteriManager = new MusteriManager();   
            _musteriManager.MusteriEkle(musteri1, musteriler);
            _musteriManager.MusteriEkle(musteri2, musteriler);

            _musteriManager.MusteriListeleme(musteriler);
            _musteriManager.MusteriSilme(musteri2 ,musteriler);
            _musteriManager.MusteriListeleme(musteriler);


        }
    }
}