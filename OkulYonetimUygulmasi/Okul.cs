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
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public AracGerecler araclar;
        public void YeniOgrenciEkle(int stdntNumber, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
           Ogrenci stdnt = new Ogrenci();
            stdnt.No=Ogrenciler.Count+1;
            stdnt.Ad = ad;
            stdnt.Soyad = soyad;
            stdnt.DogumTarihi = dogumTarihi;
            stdnt.Sube = sube;
            stdnt.Cinsiyet = cinsiyet;
            Ogrenciler.Add(stdnt);
        }
        public void OgrenciGuncelle(int stdntNumber,string ad,string soyad,DateTime dogumTarihi,CINSIYET cinsiyet,SUBE sube)
        {
            Ogrenci o = Ogrenciler.FirstOrDefault(o => o.No == stdntNumber);
            o.Ad = ad;
            o.Soyad = soyad;
            o.DogumTarihi = dogumTarihi;
            o.Sube = sube;
            o.Cinsiyet = cinsiyet;            
        }
        public void OgrenciSil(int no)
        {
            Ogrenciler.RemoveAt(no);
        }


        public void NotEkle(int no, string ders, int not)
        {
            Ogrenci o = Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
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




        public void SubedekiEnyuksekNotlu5Ogrenci(SUBE secilenSube)
        {
            //if (Ogrenciler == null || !Ogrenciler.Any())
            ////ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            //{
            //    Console.WriteLine("Listelenecek öğrenci yok.");
            //    return;
            //}

            var subedeenYuksekNotlu5Ogrenci = Ogrenciler.OrderByDescending(o => o.Ortalama)  // Not ortalamasına göre azalan sırada sıralar
                                                     .Take(5)  // İlk 5 öğrenciyi alır
                                                        .ToList();


            ListeleOgrenciler(subedeenYuksekNotlu5Ogrenci);
        }
        public static List<Ogrenci> SubedekiEnyuksekNotlu5Ogrenci(List<Ogrenci> liste)
        {
            //if (Ogrenciler == null || !Ogrenciler.Any())
            ////ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            //{
            //    Console.WriteLine("Listelenecek öğrenci yok.");
            //    return;
            //}

            return liste.OrderByDescending(o => o.Ortalama)  // Not ortalamasına göre azalan sırada sıralar
                                                     .Take(5)  // İlk 5 öğrenciyi alır
                                                        .ToList();


            //ListeleOgrenciler(subedeenYuksekNotlu5Ogrenci);
        }
        public void SubedekiEndusukNotlu3Ogrenci(SUBE secilenSube)
        {
            if (Ogrenciler == null || !Ogrenciler.Any())//ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return;
            }

            var subedeenDusukNotlu3Ogrenci = Ogrenciler.Where(o => o.Sube == secilenSube)
                                                   .OrderBy(o => o.Ortalama)
                                                   .Take(3)
                                                   .ToList();

            ListeleOgrenciler(subedeenDusukNotlu3Ogrenci);
        }
        public void OkuldakiEnyuksekNotlu5Ogrenci()
        {
            if (Ogrenciler == null || !Ogrenciler.Any())//ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return;
            }

            var okuldaenYuksekNotlu5Ogrenci = Ogrenciler.OrderByDescending(o => o.Ortalama)
                                                    .Take(5)
                                                    .ToList();

            ListeleOgrenciler(okuldaenYuksekNotlu5Ogrenci);
        }
        public void OkuldakiEndusukNotlu3Ogrenci()
        {
            if (Ogrenciler == null || !Ogrenciler.Any()) //ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return;
            }
            else
            {
                var okuldaenDusukNotlu3Ogrenci = Ogrenciler.OrderBy(o => o.Ortalama)
                                                   .Take(3)
                                                   .ToList();

                ListeleOgrenciler(okuldaenDusukNotlu3Ogrenci);
            }

        }
        public static void ListeleOgrenciler(List<Ogrenci> ogrenciler)
        {
            if (ogrenciler.Count == 0 || ogrenciler == null)
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return;
            }

            Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
            Console.WriteLine("-------------------------------------------------------------------------------");
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) +
                                  item.Ad + " " +
                                  item.Soyad.PadRight(19) +
                                  item.Ortalama.ToString().PadRight(15) + item.Kitaplar.Count());
            }

        }


    }

}
