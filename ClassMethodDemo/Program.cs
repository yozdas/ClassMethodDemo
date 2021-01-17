using System;

namespace ClassMethodDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            
            char q;

            string No;

            Musteri musteri1 = new Musteri() { };
            MusteriManager musteriManager = new MusteriManager();

            while (true)
            {
                Console.WriteLine(" -Müşteri Eklemek için 1 \n -Silmek için 2 \n -Listelemek 3 girin ve Enter \n -Çıkmak için q");
                q = Convert.ToChar(Console.ReadLine());

                if (q == '1')
                {
                    
                                      
                    Musteri musteri = new Musteri() { };
                    Console.WriteLine("Müşteri Adı: ");
                    musteri.Ad = Console.ReadLine().ToString();

                    Console.WriteLine("Müşteri Soyadı: ");
                    musteri.Soyad = Console.ReadLine().ToString();

                    musteri.Id = rnd.Next(5000);
                    musteri.MusteriNo = rnd.Next(50001, 100001).ToString();

                    Musteri[] musteriler = new Musteri[] { musteri };
                   
                    musteriManager.Ekle(musteriler);
                    musteriManager.Liste();

                        
                }
                else if (q == '2')
                {
                    Console.WriteLine("Silinecek Müşteri No:");
                    No = Console.ReadLine().ToString();
                    musteriManager.Sil(No);
                    

                }
                else if (q == '3')
                {
                    Console.WriteLine("Müşteri Listesi");
                    musteriManager.Liste();
                }
                if (q == 'q')
                {
                    break;
                }
            }
            
           
        }

       
    }
}
