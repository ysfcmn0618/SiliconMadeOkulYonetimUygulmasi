using System;
using static OkulYonetimUygulmasi.Ogrenci;

namespace OkulYonetimUygulmasi
{
    internal class Program
    {
        // kullanıcı ile etkileşime geçtiğimiz kodları bu sınıfta yazacağız.

        // Okul sınıfı verilerine ulaşabilmek için okul nensnesi oluşturduk
        static Okul Okul = new Okul();
        static int sayac = 0;
        static void Main(string[] args)
        {
            Uygulama.Uygulamaa();
            
        }

        //static void Uygulama()
        //{
        //    Menu();
        //    while (true)
        //    {
        //        string secim = SecimAl();
        //        Console.WriteLine();
        //        switch (secim)
        //        {


        //            case "1":
        //                TumOgrenciler();
        //                break;
        //            case "2":
        //                SubeyeGoreOgrenciler();
        //                break;
        //            case "3":
        //                CinsiyeteGoreOgrenciler();
        //                break;
        //            case "4":
        //                TarihSonrasıDoganlar();
        //                break;
        //            case "5":
        //                IllereGoreOgrenciler();
        //                break;
        //            case "6":
        //                OgrencininNotları();
        //                break;
        //            case "7":
        //                OkuduguKitaplar();
        //                break;
        //            case "8":
        //                EnyuksekNotlu5Ogrenci();
        //                break;
        //            case "9":
        //                EndusukNotlu3Ogrenci();
        //                break;
        //            case "10":
        //                SubedekiEnyuksekNotlu5Ogrenci();
        //                break;
        //            case "11":
        //                SubedekiEndusukNotlu3Ogrenci();
        //                break;
        //            case "12":
        //                OgrenciNotOrtalaması();
        //                break;
        //            case "13":
        //                SubeNotOrtalaması();
        //                break;
        //            case "14":
        //                OkunanSonKitap();
        //                break;
        //            case "15":
        //                OgrenciEkle();
        //                break;
        //            case "16":
        //                OgrenciGuncelle();
        //                break;
        //            case "17":
        //                OgrenciSil();
        //                break;
        //            case "18":
        //                AdresEkle();
        //                break;
        //            case "19":
        //                OgrencininOkuduguKitabıEkle();
        //                break;
        //            case "20":
        //                NotEkle();
        //                break;
        //            case "ÇIKIŞ":
        //                Cikis();
        //                break;

        //            default:
        //                Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
        //                sayac++;
        //                break;


        //        }

        //    }

        //}
        //static void Menu()
        //{

        //    Console.WriteLine("------Okul Yönetim Uygulamasi  -----");
        //    Console.WriteLine();
        //    Console.WriteLine("1 - Bütün öğrencileri listele");
        //    Console.WriteLine("2 - Şubeye göre öğrencileri listele");
        //    Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
        //    Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
        //    Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
        //    Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
        //    Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
        //    Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
        //    Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
        //    Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
        //    Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
        //    Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
        //    Console.WriteLine("13 - Şubenin not ortalamasını gör");
        //    Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
        //    Console.WriteLine("15 - Öğrenci ekle");
        //    Console.WriteLine("16 - Öğrenci güncelle");
        //    Console.WriteLine("17 - Öğrenci sil");
        //    Console.WriteLine("18 - Öğrencinin adresini gir");
        //    Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
        //    Console.WriteLine("20 - Öğrencinin notunu gir");
        //    Console.WriteLine();
        //    Console.WriteLine("çıkış yapmak için \"çıkış\" yazıp \"enter\"a basın.");



        //}
        public void SecimAl()
        {
            Console.Write("Yapmak istediginiz islemi seçiniz: ");
            Console.WriteLine();
            if (sayac != 10)
            {
                Console.WriteLine();
                Console.WriteLine("Yapmak istediginiz islemi seçiniz: ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                Cikis();
            }

        }


        static void NotGir()
        {
            try
            {
                Console.WriteLine("20-Not Gir ----------------------------------------------------------");
                Console.Write("Öğrencinin numarası: ");
                int no = int.Parse(Console.ReadLine());

                // bu numaralı öğrencinin bilgileri bulunup ekrana yazılacak.

                //
                string ders = Console.ReadLine();

                //
                int adet = int.Parse(Console.ReadLine());

                for (int i = 1; i <= adet; i++)
                {
                    Console.Write(i + ". notu girin : ");
                    int not = int.Parse(Console.ReadLine());
                    Okul.NotEkle(no, ders, not);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }




        static void SahteVeriGir()
        {
            Okul.OgrenciEkle();
            // başka öğrenciler de eklenir.

            // adres
            // ders notu
            // kitap
            // gibi veriler için de sahte veri oluşturulmalı




        }
        static void Cikis()
        {
            Environment.Exit(0);
        }

    }
}
