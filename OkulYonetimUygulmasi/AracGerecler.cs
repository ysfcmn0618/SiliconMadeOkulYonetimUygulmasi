using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class AracGerecler
    {
        public static bool OgrenciVarMi(List<Ogrenci> list)
        {
            if (list == null || !list.Any())
            //ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return false;
            }
            return true;
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
                    continue;
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
                if (!tarihMi)
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
        public int SayiKontrol(string mesaj, List<Ogrenci> list)
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
                if (!sayiMi)
                {
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                    continue;
                }
                if (!ListedeBuNumaradaOgrenciVarMi(sayi, list))
                {
                    Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                    continue;
                }               
            } while (sayiMi);
            return sayi;
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
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                    continue;
                }
                else if (sayi <= 0 || sayi >= 100)
                {
                    Console.WriteLine("Girdiginiz deger 0 ve 100 arasında olmalıdır.");
                    continue;
                }
                else
                {
                    sayiMi = true;
                }
            } while (!sayiMi);
            return sayi;
        }
        public bool ListedeBuNumaradaOgrenciVarMi(int index, List<Ogrenci> list)
        {
            if (list.Find(o => o.No == index) != null)
            {
                return true;
            }
            return false;
        }
        public Ogrenci ListedekiOgrenci(List<Ogrenci> ogrenciler, int no)
        {
            return ogrenciler.FirstOrDefault(o => o.No == no);
        }
        static public void Bilgi()
        {
            Console.WriteLine();
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
                string giris = Console.ReadLine().ToLower();

                bool sayiMi = int.TryParse(giris, out int a);
                if (sayiMi)
                {
                    return giris;
                }
                if (giris == "çıkıs")
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
