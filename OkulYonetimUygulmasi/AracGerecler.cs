using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class AracGerecler
    {

        public static Ogrenci OgrenciBilgileriniAl()
        {
            //Ogrenci  bilgilerini alacak readlinelı metod doldurulacak
            Ogrenci stdnt = new Ogrenci();
            return stdnt;
        }
        public static Ogrenci OgrenciBilgileriniAl(Ogrenci o)
        {
            //Ogrenci  bilgilerini alacak readlinelı metod doldurulacak
            Ogrenci stdnt = new Ogrenci();
            return stdnt;
        }       

        /// <summary>
        /// Mesaj ile aldığı string metin ifadesi için bir girdi değeri isteyecek ve bu mesaj ifadesinin karşılığı olarak geri döndürecek
        /// </summary>
        /// <param name="mesaj"></param>
        /// <returns></returns>
        public string MetinKontrol(string mesaj)
        {
            //girilen ifade int ise tekrar veri girmesini isteyecek
            //string ise veriyi tutacak
            string girdi;
            bool deger = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine();
                bool sayiMi = int.TryParse(girdi, out int a);
                if (sayiMi)
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                }
                else
                {
                    deger = true;
                }
            } while (!deger);
            return girdi;
        }
        public Ogrenci.CINSIYET CinsiyetKontrol(string mesaj)
        {
            //girilen ifade int ise tekrar veri girmesini isteyecek
            //string ise veriyi tutacak
            string girdi;
            bool deger = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine().ToUpper();
                if (girdi != "E" && girdi != "K")
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                }
                else
                {
                    deger = true;
                }
            } while (!deger);
            return Enum.Parse<Ogrenci.CINSIYET>(girdi);
        }
        public Ogrenci.SUBE SubeKontrol(string mesaj)
        {
            //girilen ifade int ise tekrar veri girmesini isteyecek
            //string ise veriyi tutacak
            string girdi;
            bool deger = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine().ToUpper();
                if (girdi != "A" && girdi != "B" && girdi != "C")
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                }
                else
                {
                    deger = true;
                }
            } while (!deger);
            return Enum.Parse<Ogrenci.SUBE>(girdi);
        }
        /// <summary>
        /// Mesaj ile aldığı DateTime metin ifadesi için bir girdi değeri isteyecek ve bu mesaj ifadesinin karşılığı olarak geri döndürecek
        /// </summary>
        /// <param name="mesaj"></param>
        /// <returns></returns>
        public DateTime TarihKontrol(string mesaj)
        {
            //girilen ifade Datetime değil ise tekrar veri girmesini isteyecek
            //Datetime  ise veriyi tutacak geri döndürecek
            string girdi;
            DateTime tarih;
            bool deger = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine();
                bool tarihMi = DateTime.TryParse(girdi, out tarih);
                if (tarihMi)
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                }
                else
                {
                    deger = true;
                }
            } while (!deger);
            return tarih;
        }
        public int SayiKontrol(string mesaj)
        {
            //girilen ifade int ise tekrar veri girmesini isteyecek
            //string ise veriyi tutacak
            string girdi;
            int sayi;
            bool sayiMi = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine();
                sayiMi = int.TryParse(girdi, out sayi);
                if (sayiMi)
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                    continue;
                }
                else
                {
                    sayiMi = true;
                }
            } while (!sayiMi);
            return sayi;            
        }
        static public void Bilgi()
        {
            Console.WriteLine($"Menüyü tekrar listelemek için \"liste\", çıkıs yapmak için \"çıkış\" yazın.");
            Console.WriteLine();
        }
        public static string SecimAl()
        {
            int sayac = 0;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                string giris = Console.ReadLine();

                bool sayiMi = int.TryParse(giris, out int a);
                if (sayiMi)
                {
                    return giris;
                }
                if (giris == "çıkış")
                {
                    Uygulama.Cikis();
                }
                if (giris == "liste")
                {
                    Uygulama.Menu();
                }
                else
                {
                    sayac++;
                    Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                    if (sayac == 10)
                    {
                        Environment.Exit(0);
                    }

                }
            }
        }        
    }
}
