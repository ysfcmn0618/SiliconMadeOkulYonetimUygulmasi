using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OkulYonetimUygulmasi.Ogrenci;

namespace OkulYonetimUygulmasi
{
    internal class Okul
    {
        // Okula ait herhangi bir bilginin değiştirilme işlemleri bu sınıfta yapılmalı
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle()
        {
            int no=1; string ad=""; string soyad=""; DateTime dogumTarihi= DateTime.Now; CINSIYET cinsiyet=CINSIYET.Erkek; SUBE sube=SUBE.A;
            Ogrenci o = new Ogrenci(no, ad, soyad, dogumTarihi, cinsiyet, sube) { };           

            // 
            //

            this.Ogrenciler.Add(o);
        }


        public void NotEkle(int no, string ders,int not )
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o!=null)
            {
                o.Notlar.Add(new DersNotu(ders, not));
            }
        }
        public void TumOgrenciler()
        {
            foreach (var item in Ogrenciler)
            {
                Console.WriteLine(item.Ad);
            }
        }
       
    }
}
