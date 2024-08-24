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
        public AracGerecler araclar;

        public void OgrenciEkle()
        {
            Ogrenci stdnt=AracGerecler.OgrenciBilgileriniAl();        

            this.Ogrenciler.Add(stdnt);
        }
        public void OgrenciGuncelle(int stdntNumber)
        {
            Ogrenci o = Ogrenciler.FirstOrDefault(o=> o.No==stdntNumber);
            o=araclar.OgrenciBilgileriniAl();
            //Bu bilgileri almam lazım
            o.OgrenciGuncelle(araclar.OgrenciBilgileriniAl());
           // o.OgrenciGuncelle(o.Ad,o.Soyad,o.DogumTarihi,o.Cinsiyet,o.Sube);
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

         /// <summary>
 /// Girilen şubeye göre öğrencileri filtreleyip, notlarına göre yüksekten sıralar
 /// </summary>
//  public void SubedekiEnyuksekNotlu5Ogrenci()
//  {
//      Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");
//      SUBE secilenSube;
//      bool gecerliGiris = false;

//     while(!gecerliGiris)
//      {
//          Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
//          string giris = Console.ReadLine();
//          if (Enum.TryParse(giris, true, out secilenSube))//enum tipinde doğru giriş olup olmadığını kontrol eder.
//          {
//              gecerliGiris = true; //doğru tipte giriş yapıldığında şube istemeyi durdurur.
            
//              if (Ogrenciler == null)
//              {
//                  Console.WriteLine("Listelenecek ögrenci yok.");
//                  return;
//              }
//              var enYuksekNotluOgrenciler = Ogrenciler.Where(o => o.Sube == secilenSube).OrderByDescending(o => o.Ortalama).Take(5).ToList();

//              if (enYuksekNotluOgrenciler.Count == 0)
//              {
//                  Console.WriteLine("Listelenecek ögrenci yok.");
                 
//              }
//              else
//              {
//                  Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
//                  Console.WriteLine("-------------------------------------------------------------------------------");
//                  foreach (var item in enYuksekNotluOgrenciler)
//                  {
//                      Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) +
//                                item.Ad + " " +
//                                item.Soyad.PadRight(19) +
//                                item.Ortalama.ToString().PadRight(15) + item.Kitaplar.Count());
//                  }
//              }

//          }
//          else//enum tipine uygun giriş yapılmadığında hata verir.
//          {
//              Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
//          }
//      }
   
//  }

//  public void SubedekiEndusukNotlu3Ogrenci()
//  {
//      Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");
//      SUBE secilenSube;
//      bool gecerliGiris = false;

//      while (!gecerliGiris)
//      {
//          Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
//          string giris = Console.ReadLine();
//          if (Enum.TryParse(giris, true, out secilenSube))//enum tipinde doğru giriş olup olmadığını kontrol eder.
//          {
//              gecerliGiris = true; //doğru tipte giriş yapıldığında şube istemeyi durdurur.

//              if (Ogrenciler == null)
//              {
//                  Console.WriteLine("Listelenecek ögrenci yok.");
//                  return;
//              }
//              var enYuksekNotluOgrenciler = Ogrenciler.Where(o => o.Sube == secilenSube).OrderBy(o => o.Ortalama).Take(3).ToList();

//              if (enYuksekNotluOgrenciler.Count == 0)
//              {
//                  Console.WriteLine("Listelenecek ögrenci yok.");

//              }
//              else
//              {
//                  Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
//                  Console.WriteLine("-------------------------------------------------------------------------------");
//                  foreach (var item in enYuksekNotluOgrenciler)
//                  {
//                      Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) +
//                                item.Ad + " " +
//                                item.Soyad.PadRight(19) +
//                                item.Ortalama.ToString().PadRight(15) + item.Kitaplar.Count());
//                  }
//              }

//          }
//          else//enum tipine uygun giriş yapılmadığında hata verir.
//          {
//              Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
//          }
//      }

//  }

// public void OkuldakiEnyuksekNotlu5Ogrenci()
// {
//     Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");


//     if (Ogrenciler == null || Ogrenciler.Count == 0)
//     {
//         Console.WriteLine("Listelenecek öğrenci yok");
//         return;
//     }
//     var enYuksekNotluOgrenciler = Ogrenciler.OrderByDescending(o => o.Ortalama)  // Not ortalamasına göre azalan sırada sıralar
//                                              .Take(5)  // İlk 5 öğrenciyi alır
//                                                 .ToList();

//     if (enYuksekNotluOgrenciler.Count == 0)
//     {
//         Console.WriteLine("Listelenecek ögrenci yok.");

//     }
//     else
//     {
//         Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
//         Console.WriteLine("-------------------------------------------------------------------------------");
//         foreach (var item in enYuksekNotluOgrenciler)
//         {
//             Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) +
//                       item.Ad + " " +
//                       item.Soyad.PadRight(19) +
//                       item.Ortalama.ToString().PadRight(15) + item.Kitaplar.Count());
//         }
//     }

// }

// public void OkuldakiEndusukNotlu3Ogrenci()
// {
//     Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");


//     if (Ogrenciler == null || Ogrenciler.Count == 0)
//     {
//         Console.WriteLine("Listelenecek öğrenci yok");
//         return;
//     }
//     var enYuksekNotluOgrenciler = Ogrenciler.OrderBy(o => o.Ortalama)  // Not ortalamasına göre artan sırada sıralar
//                                              .Take(3)  // İlk 5 öğrenciyi alır
//                                                 .ToList();

//     if (enYuksekNotluOgrenciler.Count == 0)
//     {
//                 Console.WriteLine("Listelenecek ögrenci yok.");

//     }
//     else
//     {
//         Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
//         Console.WriteLine("-------------------------------------------------------------------------------");
//         foreach (var item in enYuksekNotluOgrenciler)
//         {
//             Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) +
//                       item.Ad + " " +
//                       item.Soyad.PadRight(19) +
//                       item.Ortalama.ToString().PadRight(15) + item.Kitaplar.Count());
//         }
//     }

// }

       
    }
}
