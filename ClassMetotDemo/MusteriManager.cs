using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri, ArrayList musteriler) 
        {
            musteriler.Add(musteri);        
        }
        public void MusteriSilme(Musteri musteri, ArrayList musteriler)
        {
            musteriler.Remove(musteri);
        }
        public void MusteriListeleme(ArrayList musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
