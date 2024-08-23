using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class AracGerecler
    {


        public static string SecimAl(string mesaj)
        {
            //gelen string mesaj int sayı mı değilmi diye bak sayi ise bu numarada lsite seçeneği var mı ve gelen liste is menuyü çalıştır çıkıs ise programı sonlandır.
            string girdi;
            bool dogru = false;
            do
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine();

                if (girdi == "çıkış")
                {
                    Uygulama.Cikis();
                }
                else if (girdi == "liste")
                {
                    Uygulama.Menu();
                }
                else
                {
                    dogru = true;
                }

            } while (!dogru);
            girdi = girdi.Substring(0, 1).ToUpper();
            return girdi;
        }
        public static string SecimAl()
        {
            //gelen string mesaj int sayı mı değilmi diye bak sayi ise bu numarada lsite seçeneği var mı ve gelen liste is menuyü çalıştır çıkıs ise programı sonlandır.
            string girdi;
            bool dogru = false;
            do
            {
                girdi = Console.ReadLine();

                if (girdi == "çıkış")
                {
                    Uygulama.Cikis();
                }
                else if (girdi == "liste")
                {
                    Uygulama.Menu();
                }
                else
                {
                    dogru = true;
                }

            } while (!dogru);
            girdi = girdi.Substring(0, 1).ToUpper();
            return girdi;
        }
        public static string MetinKontrol(string mesaj)
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

        static public void Bilgi()
        {
            Console.WriteLine($"Menüyü tekrar listelemek için \"liste\", çıkıs yapmak için \"çıkış\" yazın.");
            Console.WriteLine();
        }
    }
}
