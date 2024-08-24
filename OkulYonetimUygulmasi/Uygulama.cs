using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OkulYonetimUygulmasi.Ogrenci;

namespace OkulYonetimUygulmasi
{
    // https://drive.google.com/file/d/1VV4iqMoI2po96cpZfGymMDAnkEeoWJNV/view?usp=sharing
    internal class Uygulama
    {
        public static Okul okul;
        public static List<Ogrenci> ogrenciler = okul.Ogrenciler;
        public static AracGerecler araclar;

        public static void Cikis()
        {
            Environment.Exit(0);
        }
        public static void Menu()
        {
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele(Alfabetik sıralama olacak ");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele(Derse göre sıralayıp listelenecek");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör(Öğrenciye ait ortalama özelliği olacak, set özelliği olmayacak, get özelliği içinde hesaplanıp döndürülecek");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle(yeni öğrenci yaratılmayacak, var olan öğrenci nesnesi üzerinden güncelleme yapılacak.)");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir(Öğrencinin adresi farklı bir class olacak ");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir(Metot ile giriş yapılacak");

        }
        public static void Uygulamaa()
        {
            Menu();
            while (true)
            {
                string secim = AracGerecler.SecimAl();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                        TümOgrenciler();
                        break;
                    case "2":
                        SubeyeGoreOgrenciler();
                        break;
                    case "3":
                        CinsiyeteGoreOgrenciler();
                        break;
                    case "4":
                        TarihSonrasıDoganlar();
                        break;
                    case "5":
                        IllereGoreOgrenciler();
                        break;
                    case "6":
                        OgrencininNotları();
                        break;
                    case "7":
                        OkuduguKitaplar();
                        break;
                    case "8":
                        EnyuksekNotlu5Ogrenci();
                        break;
                    case "9":
                        EndusukNotlu3Ogrenci();
                        break;
                    case "10":
                        SubedekiEnyuksekNotlu5Ogrenci();
                        break;
                    case "11":
                        SubedekiEndusukNotlu3Ogrenci();
                        break;
                    case "12":
                        OgrenciNotOrtalaması();
                        break;
                    case "13":
                        SubeNotOrtalaması();
                        break;
                    case "14":
                        OkunanSonKitap();
                        break;
                    case "15":
                        OgrenciEkle();
                        break;
                    case "16":
                        OgrenciGuncelle();
                        break;
                    case "17":
                        OgrenciSil();
                        break;
                    case "18":
                        AdresEkle();
                        break;
                    case "19":
                        OgrencininOkuduguKitabıEkle();
                        break;
                    case "20":
                        NotEkle();
                        break;
                    case "ÇIKIŞ":
                        Cikis();
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        sayac++;
                        break;


                }
            }
        }

        private static void OgrencininNotları()
        {
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");
            int girdi = araclar.SayiKontrol("Ögrencinin numarasi:",ogrenciler);
            Ogrenci ogre = ogrenciler.Find(o => o.No == girdi);
            Console.WriteLine("Dersin Adi     Notu");
            Console.WriteLine("--------------------");
            foreach (var o in ogre.Notlar)
            {
                Console.WriteLine($"{o.DersAdi}         {o.Not}");
            }
        }

        private static void IllereGoreOgrenciler()
        {
            Console.WriteLine("5-Illere Göre Ögrencileri Listele --------------------------------------------");
            Console.WriteLine();
            
            if (AracGerecler.OgrenciVarMi(ogrenciler))
            {
                Console.WriteLine("Sube      No        Adı Soyadı           Sehir          Semt");
                Console.WriteLine("---------------------------------------------------------------------------");
                ogrenciler.OrderBy(o => o.Adres.Il);
                foreach (var o in ogrenciler)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}          {o.Adres.Il}         {o.Adres.Ilce}");
                }
            }
        }

        private static void TarihSonrasıDoganlar()
        {
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele -------------------------------------");
            DateTime date = araclar.TarihKontrol("Hangi tarihten sonraki ögrencileri listelemek istersiniz:");
            List<Ogrenci> newList = ogrenciler.Where(s => s.DogumTarihi > date).ToList();
            if (AracGerecler.OgrenciVarMi(newList))
            {
                Console.WriteLine();
                Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach (var o in newList)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}   ");
                }
            }
        }

        private static void CinsiyeteGoreOgrenciler()
        {
            Console.WriteLine("3-Cinsiyete Göre Ögrencileri Listele -----------------------------------------")
            CINSIYET cinsiyet = araclar.CinsiyetKontrol("Listelemek istediginiz cinsiyeti girin (K/E):");
            List<Ogrenci> newList = ogrenciler.Where(s => s.Cinsiyet == cinsiyet).ToList();
            if (AracGerecler.OgrenciVarMi(newList))
            {
                Console.WriteLine();
                Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach (var o in newList)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}   ");
                }
            }
        }

        public Ogrenci OgrenciBilgileriniAl()
        {
            Ogrenci o = new Ogrenci();
            //o.No = studys.Last().No + 1;
            o.Ad = araclar.MetinKontrol("Ögrencinin adı: ");
            o.Soyad = araclar.MetinKontrol("Ögrencinin soyadı: ");
            o.DogumTarihi = araclar.TarihKontrol("Ögrencinin dogum tarihi:");
            o.Cinsiyet = araclar.CinsiyetKontrol("Ögrencinin cinsiyeti (K/E):");
            o.Sube = araclar.SubeKontrol("Ögrencinin subesi (A/B/C):");
            return o;
        }
        public static void SubeyeGoreOgrenciler()
        {
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");
            SUBE sube = araclar.SubeKontrol("Listelemek istediginiz subeyi girin (A/B/C):");
            List<Ogrenci> newList = ogrenciler.Where(s => s.Sube == sube).ToList();
            if (AracGerecler.OgrenciVarMi(newList))
            {
                Console.WriteLine();
                Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach (var o in newList)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}   ");
                }
            }
        }
        public static void TümOgrenciler()
        {
            Console.WriteLine("1-Bütün Öğrencileri Listele --------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
            Console.WriteLine("---------------------------------------------------------------------------");

            if (AracGerecler.OgrenciVarMi(ogrenciler))
            {
                foreach (var o in ogrenciler)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}   ");
                }
            }
        }
        public static void SubedekiEnyuksekNotlu5Ogrenci()
        {
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");

            if (ogrenciler == null || !ogrenciler.Any())
            //ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                Console.WriteLine("Listelenecek öğrenci yok.");
                return;
            }
            List<Ogrenci> besOgrenci = Okul.SubedekiEnyuksekNotlu5Ogrenci(ogrenciler);


            //Ogrenci.SUBE secilenSube = araclar.SubeKontrol("\"Listelemek istediğiniz şubeyi girin (A/B/C): \"");
            //var subedeenYuksekNotlu5Ogrenci = ogrenciler.OrderByDescending(o => o.Ortalama)  // Not ortalamasına göre azalan sırada sıralar
            //                                         .Take(5)  // İlk 5 öğrenciyi alır
            //                                            .ToList();
            //okul.SubedekiEnyuksekNotlu5Ogrenci(secilenSube);
        }
        public static void SubedekiEnDusukNotlu3Ogrenci()
        {
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");

            SUBE secilenSube = SubeSecimi();
            okul.SubedekiEndusukNotlu3Ogrenci(secilenSube);
        }
        public static void OkuldakiEnYuksekNotlu5Ogrenci()
        {
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");

            okul.OkuldakiEnyuksekNotlu5Ogrenci();
        }
        public static void OkuldakiEnDusukNotlu3Ogrenci()
        {
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");

            okul.OkuldakiEndusukNotlu3Ogrenci();
        }

    }
}
