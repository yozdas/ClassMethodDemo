using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class MusteriManager
    {
        Musteri musteri = new Musteri() { };

        public void Ekle(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                musteri.Id = musteriler[i].Id;
                musteri.MusteriNo = musteriler[i].MusteriNo;
                musteri.Ad = musteriler[i].Ad;
                musteri.Soyad = musteriler[i].Soyad;

            }

        }

        public void Liste()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Adı: {musteri.Ad} SoyAdı: {musteri.Soyad} Müşteri Nosu: {musteri.MusteriNo} Id: {musteri.Id}");
            Console.WriteLine("---------------------------");
        }

        public void Sil(string no)
        {
            Console.WriteLine("Silindi");
        }


    }
}
