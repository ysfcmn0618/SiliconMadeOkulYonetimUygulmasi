using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class Ogrenci
    {      
        public Ogrenci(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            No = no;
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            Sube = sube;
        }

        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public float Ortalama
        {
            get
            {
                return Notlar.Average(n => (float)n.Not);
            }
        }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public Adres Adresi;

        public List<DersNotu> Notlar = new List<DersNotu>();
        public List<string> Kitaplar = new List<string>();

        public void KitapEkle(string bookName)
        {
            Kitaplar.Add(bookName);
        }

        /// <summary>
        /// Öğrenciye ait bütün dersleri ve notlarını ekrana yazar
        /// </summary>
        public void OgrencininNotlari()
        {
            OgrenciBilgi();
            Console.WriteLine("Dersin Adi Notu");
            Console.WriteLine("--------------------");
            foreach (var item in Notlar)
            {
                Console.WriteLine($"{item.DersAdi}         {item.Not}");
            }
            AracGerecler.Bilgi();
        }
        /// <summary>
        /// Öğrencinin Ad-Soyad ve Şube bilgisini ekrana yazar
        /// </summary>
        public void OgrenciBilgi()
        {
            Console.WriteLine();
            Console.WriteLine($"Ögrencinin Adı Soyadı: {Ad + " " + Soyad}");
            Console.WriteLine($"Ögrencinin Subesi: {Sube}");
            Console.WriteLine();
        }
        /// <summary>
        /// Kitaplar listesinin tamamını ekrana yazar
        /// </summary>
        public void OkuduguKitaplar()
        {
            OgrenciBilgi();
            Console.WriteLine("Okudugu Kitaplar");
            Console.WriteLine("-----------------");
            foreach (var item in Kitaplar)
            {
                Console.WriteLine(item);
            }

        }
       
        /// <summary>
        /// Kitaplar listesinde eklenen en son kitabı döndürür
        /// </summary>
        public void OkunanSonKitap()
        {
            Console.WriteLine(Kitaplar.Last().ToString());
        }

        public enum SUBE
        {
            Empty, A, B, C
        }

        public enum CINSIYET
        {
            Empty, Kiz, Erkek
        }

    }
}