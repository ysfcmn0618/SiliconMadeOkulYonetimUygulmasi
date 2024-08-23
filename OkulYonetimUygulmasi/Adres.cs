using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class Adres
    {
        Adres() { }
        Adres(string il, string ilce, string mahalle)
        {
            Il = il;
            Ilce = ilce;
            Mahalle = mahalle;
        }
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public string Il;
        public string Ilce;
        public string Mahalle { get; set; }




        public void AdresEkle(int no)
        {
            Console.WriteLine("18-Ögrencinin Adresini Gir ------------------------------------------");           
            int girdiNo;
            bool numara = true;
            do
            {
                Console.Write("Ögrencinin numarasi: ");
                numara = int.TryParse(Console.ReadLine(), out girdiNo);
                if (!numara)
                {
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                    return;
                }

            } while (numara);
            Ogrenci o = Ogrenciler.FirstOrDefault(a => a.No == girdiNo);//numara eşlemek için

            if (o != null)
            {
                // Öğrenci var mı kontorl edip, bilgilerini ekrana yazdıracak
                o.OgrenciBilgi();
                // Adres bilgilerini alacak
                string il = AracGerecler.MetinKontrol("İl: ");
                string ilce = AracGerecler.MetinKontrol("İlçe: ");
                string mahalle = AracGerecler.MetinKontrol("Mahalle: ");
                // Adres bilgilerini öğrencinin adresine ekle
                o.Adresi = new Adres(il,ilce,mahalle) { };
                Console.WriteLine("Adres başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Bu numarada bir öğrenci yok. Tekrar deneyin.");
                return;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void IllereGoreOgrenciler()
        {
            if (Ogrenciler != null)
            {
                List<Ogrenci> yeniListe = new List<Ogrenci>();
                yeniListe = Ogrenciler.OrderBy(o => o.Adresi.Il).ThenBy(o => o.No).ToList(); //Ogrenciler listesini gez ve önce şehir adlarına göre sonra da numaralarına göre sırala
            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
        }
    }
}
