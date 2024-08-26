using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static OkulYonetimUygulmasi.Ogrenci;

namespace OkulYonetimUygulmasi
{
    // https://drive.google.com/file/d/1VV4iqMoI2po96cpZfGymMDAnkEeoWJNV/view?usp=sharing
    internal class Uygulama
    {
        public static Okul okul = new Okul();       
        public static AracGerecler araclar = new AracGerecler();

        public static void Cikis()
        {
            Environment.Exit(0);
        }
        public static void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine();
            Console.WriteLine("çıkıs yapmak için \"çıkıs\" yazıp \"enter\"a basın.");
        }
        public static void Uygulamaa()
        {
            SahteVeriGir();
            Menu();
            while (true)
            {
                string secim = AracGerecler.SecimAl();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                        TümOgrenciler();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "2":
                        SubeyeGoreOgrenciler();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "3":
                        CinsiyeteGoreOgrenciler();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "4":
                        TarihSonrasıDoganlar();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "5":
                        IllereGoreOgrenciler();
                            Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "6":
                        OgrencininNotları();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "7":
                        OkuduguKitaplar();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "8":
                        OkuldakiEnYuksekNotlu5Ogrenci();
                            Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "9":
                        OkuldakiEnDusukNotlu3Ogrenci();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "10":
                        SubedekiEnyuksekNotlu5Ogrenci();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "11":
                        SubedekiEnDusukNotlu3Ogrenci();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "12":
                        OgrenciNotOrtalaması();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "13":
                        SubeNotOrtalaması();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "14":
                        OkunanSonKitap();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "15":
                        OgrenciEkle();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "16":
                        OgrenciGuncelle();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "17":
                        OgrenciSil();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "18":
                        AdresEkle();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "19":
                        OgrencininOkuduguKitabıEkle();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "20":
                        NotEkle();
                        Console.WriteLine();
                        AracGerecler.Bilgi();
                        break;
                    case "ÇIKIŞ":
                        Cikis();
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        // sayac++;
                        break;


                }
            }
        }

        private static void OgrenciSil()
        {
            Console.WriteLine("17-Ögrenci sil ----------------------------------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ", Okul.Ogrenciler);
            Console.WriteLine();
            Ogrenci ogre = Okul.Ogrenciler.Find(o => o.No == numara);
            Console.WriteLine($"Ögrencinin Adı Soyadı: {ogre.Ad + " " + ogre.Soyad}");
            Console.WriteLine($"Ögrencinin Subesi: {ogre.Sube}");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Ögrenciyi silmek istediginize emin misiniz (E/H): ");
                string eh = Console.ReadLine();
                if (eh == "E")
                {
                    okul.OgrenciSil(numara);
                }
                AracGerecler.Bilgi();
            }
            catch (Exception)
            {
                AracGerecler.Bilgi();
            }
        }

        private static void OgrenciGuncelle()
        {
            Console.WriteLine("16-Ögrenci Güncelle -----------------------------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ", Okul.Ogrenciler);
            string isim = araclar.MetinKontrol("Öğrencinin Adı: ");
            string soyisim = araclar.MetinKontrol("Öğrencinin soyadı: ");
            DateTime dogumTarihi = araclar.TarihKontrol("Öğrencinin dogum tarihi: ");
            CINSIYET cinsiyet = araclar.CinsiyetKontrol("Ögrencinin cinsiyeti (K/E):");
            SUBE sube = araclar.SubeKontrol("Ögrencinin subesi (A/B/C): ");

            okul.OgrenciGuncelle(numara, isim, soyisim, dogumTarihi, cinsiyet, sube);
        }

        private static void OkunanSonKitap()
        {
            Console.WriteLine("14-Ögrencinin okudugu son kitabı listele ----------------------------");
            int no = araclar.SayiKontrol("Ögrencinin numarasi: ");
            Ogrenci ogre = Okul.Ogrenciler.Find(o => o.No == no);
            Console.WriteLine();
            Console.WriteLine($"Ögrencinin Adı Soyadı: {ogre.Ad + " " + ogre.Soyad}");
            Console.WriteLine($"Ögrencinin Subesi: {ogre.Sube}");
            Console.WriteLine();
            Console.WriteLine("Ögrencinin Okudugu Son Kitap");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(ogre.Kitaplar.Last());
        }

        private static void SubeNotOrtalaması()
        {
            Console.WriteLine("13-Subenin Not Ortalamasını Gör -------------------------------------");
            SUBE sube = araclar.SubeKontrol("Bir sube seçin (A/B/C): ");
            Console.WriteLine();
            float ort = Okul.Ogrenciler.Where(s => s.Sube == sube).ToList().Average(a => a.Ortalama);
            Console.WriteLine($"{sube} subesinin not ortalaması: {ort}");
            AracGerecler.Bilgi();
        }

        private static void OgrenciNotOrtalaması()
        {
            Console.WriteLine("12-Ögrencinin Not Ortalamasını Gör ----------------------------------");
            int no = araclar.SayiKontrol("Ögrencinin numarasi:", Okul.Ogrenciler);
            Ogrenci ogre = Okul.Ogrenciler.Find(o => o.No == no);
            Console.WriteLine();
            Console.WriteLine($"Ögrencinin Adı Soyadı: {ogre.Ad + " " + ogre.Soyad}");
            Console.WriteLine($"Ögrencinin Subesi: {ogre.Sube}");
            Console.WriteLine();
            Console.WriteLine("Ögrencinin not ortalaması: " + ogre.Ortalama);
            AracGerecler.Bilgi();
        }

        private static void OkuduguKitaplar()
        {
            Console.WriteLine("7-Ögrencinin okudugu kitapları listele ---------------------------------------");
            int no = araclar.SayiKontrol("Ögrencinin numarasi:", Okul.Ogrenciler);
            Ogrenci ogre = Okul.Ogrenciler.Find(o => o.No == no);
            Console.WriteLine("Okudugu Kitaplar");
            Console.WriteLine("-----------------");
            foreach (var o in ogre.Kitaplar)
            {
                Console.WriteLine(o);
            }
        }

        private static void OgrencininNotları()
        {
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");
            int girdi = araclar.SayiKontrol("Ögrencinin numarasi:", Okul.Ogrenciler);
            Ogrenci ogre = Okul.Ogrenciler.Find(o => o.No == girdi);
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

            if (AracGerecler.OgrenciVarMi(Okul.Ogrenciler))
            {
                Console.WriteLine("Sube      No        Adı Soyadı           Sehir          Semt");
                Console.WriteLine("---------------------------------------------------------------------------");
                List<Ogrenci> newList=Okul.Ogrenciler.OrderBy(o => o.Adresi.Il).ToList();
                foreach (var o in newList)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}          {o.Adresi.Il}         {o.Adresi.Ilce}");
                }
            }
        }

        private static void TarihSonrasıDoganlar()
        {
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele -------------------------------------");
            DateTime date = araclar.TarihKontrol("Hangi tarihten sonraki ögrencileri listelemek istersiniz:");
            List<Ogrenci> newList = Okul.Ogrenciler.Where(s => s.DogumTarihi > date).OrderBy(n=>n.No).ToList();
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
            Console.WriteLine("3-Cinsiyete Göre Ögrencileri Listele -----------------------------------------");
            CINSIYET cinsiyet = araclar.CinsiyetKontrol("Listelemek istediginiz cinsiyeti girin (K/E):");
            List<Ogrenci> newList = Okul.Ogrenciler.Where(s => s.Cinsiyet == cinsiyet).OrderBy(n=>n.No).ToList();
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
            List<Ogrenci> newList = Okul.Ogrenciler.Where(s => s.Sube == sube).OrderBy(n => n.No).ToList();
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
            List<Ogrenci> newList=Okul.Ogrenciler.OrderBy(s => s.No).ToList();
            if (AracGerecler.OgrenciVarMi(newList))
            {
                foreach (var o in newList)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}   ");
                }
            }
        }
        public static void SubedekiEnyuksekNotlu5Ogrenci()
        {
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");

            if (AracGerecler.OgrenciVarMi(Okul.Ogrenciler))
            //ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                SUBE sube = araclar.SubeKontrol("Listelemek istediginiz subeyi girin (A/B/C): ");
                List<Ogrenci> besOgrenci = Okul.Ogrenciler.Where(s => s.Sube == sube).OrderByDescending(o => o.Ortalama).Take(5).ToList();
                Console.WriteLine();
                Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach (var o in besOgrenci)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}");
                }
            }
            AracGerecler.Bilgi();
        }
        public static void SubedekiEnDusukNotlu3Ogrenci()
        {
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");

            if (AracGerecler.OgrenciVarMi(Okul.Ogrenciler))
            //ögrenciler listesi oluşturulmuş mu ve içinde en az 1 öge var mı kontrolü
            {
                SUBE sube = araclar.SubeKontrol("Listelemek istediginiz subeyi girin (A/B/C): ");
                List<Ogrenci> ucOgrenci = Okul.Ogrenciler.Where(s => s.Sube == sube).OrderBy(o => o.Ortalama).Take(3).ToList();
                Console.WriteLine();
                Console.WriteLine("Şube      No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach (var o in ucOgrenci)
                {
                    Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}              {o.Ortalama}           {o.Kitaplar.Count}");
                }
            }
            AracGerecler.Bilgi();
        }
        public static void OkuldakiEnYuksekNotlu5Ogrenci()
        {
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sube No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
            Console.WriteLine("------------------------------------------------------------------------------ -");
            List<Ogrenci> newList = Okul.Ogrenciler.OrderByDescending(a => a.Ortalama).Take(5).ToList();
            foreach (var o in newList)
            {
                Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}             {o.Ortalama}          {o.Kitaplar.Count}");
            }
            AracGerecler.Bilgi();
        }
        public static void OkuldakiEnDusukNotlu3Ogrenci()
        {
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sube No        Adı Soyadı               Not Ort.       Okudugu Kitap Say.");
            Console.WriteLine("------------------------------------------------------------------------------ -");
            List<Ogrenci> newList = Okul.Ogrenciler.OrderBy(a => a.Ortalama).Take(3).ToList();
            foreach (var o in newList)
            {
                Console.WriteLine($"{o.Sube}         {o.No}         {o.Ad + " " + o.Soyad}             {o.Ortalama}          {o.Kitaplar.Count}");
            }
            AracGerecler.Bilgi();
        }

        public static void SahteVeriGir()
        {
            Ogrenci ogrenci1 = new Ogrenci(1, "Elif", "Selçuk", new DateTime(2000, 10, 25), CINSIYET.K, SUBE.A);
            string Il = "Ankara";
            string Ilce = "Çankaya";
            string Mahalle = "Piyade";
            ogrenci1.AdresEkle(Il, Ilce, Mahalle);
            ogrenci1.DersNotuEkle("Türkçe", 53);
            ogrenci1.DersNotuEkle("Matematik", 38);
            ogrenci1.DersNotuEkle("Fen", 26);
            ogrenci1.DersNotuEkle("Sosyal", 5);
            ogrenci1.Kitaplar.Add("Çavdar Tarlasında Çocuklar");

            Ogrenci ogrenci2 = new Ogrenci(2, "Betül", "Yılmaz", new DateTime(1999, 05, 06), CINSIYET.K, SUBE.B);
            string a = "Ankara";
            string b = "Keçiören";
            string c = "Pınarbaşı";
            ogrenci2.AdresEkle(a, b, c);
            ogrenci2.DersNotuEkle("Türkçe", 29);
            ogrenci2.DersNotuEkle("Matematik", 31);
            ogrenci2.DersNotuEkle("Fen", 79);
            ogrenci2.DersNotuEkle("Sosyal", 77);
            ogrenci2.Kitaplar.Add("Bir Ses Böler Geceyi");

            Ogrenci ogrenci3 = new Ogrenci(3, "Hakan", "Çelik", new DateTime(1999, 07, 30), CINSIYET.E, SUBE.C);
            ogrenci3.Adresi.Il = "Ankara";
            ogrenci3.Adresi.Ilce = "Çankaya";
            ogrenci3.AdresEkle("Ankara", "Çankaya", "Alacaatlı");
            ogrenci3.DersNotuEkle("Türkçe", 88);
            ogrenci3.DersNotuEkle("Matematik", 52);
            ogrenci3.DersNotuEkle("Fen", 43);
            ogrenci3.DersNotuEkle("Sosyal", 62);
            ogrenci3.Kitaplar.Add("Jane Eyre");

            Ogrenci ogrenci4 = new Ogrenci(8, "Sinan", "Avcı", new DateTime(1990, 06, 15), CINSIYET.E, SUBE.A);
            ogrenci4.Adresi.Il = "İstanbul";
            ogrenci4.Adresi.Ilce = "Arnavutköy";
            ogrenci4.Adresi.Mahalle = "Karacailyas";
            ogrenci4.DersNotuEkle("Türkçe", 78);
            ogrenci4.DersNotuEkle("Matematik", 28);
            ogrenci4.DersNotuEkle("Fen", 49);
            ogrenci4.DersNotuEkle("Sosyal", 73);
            ogrenci4.Kitaplar.Add("Noel Şarkısı");

            Ogrenci ogrenci5 = new Ogrenci(9, "Deniz", "Çoban", new DateTime(1990, 08, 10), CINSIYET.E, SUBE.C);
            ogrenci5.Adresi.Il = "İstanbul";
            ogrenci5.Adresi.Ilce = "Beykoy";
            ogrenci5.Adresi.Mahalle = "Viranşehir";
            ogrenci5.DersNotuEkle("Türkçe", 54);
            ogrenci5.DersNotuEkle("Matematik", 57);
            ogrenci5.DersNotuEkle("Fen", 93);
            ogrenci5.DersNotuEkle("Sosyal", 39);
            ogrenci5.Kitaplar.Add("Sis ve Gece");

            Ogrenci ogrenci6 = new Ogrenci(10, "Selda", "Kavak", new DateTime(1997, 12, 01), CINSIYET.K, SUBE.B);
            ogrenci6.Adresi.Il = "İstanbul";
            ogrenci6.Adresi.Ilce = "Ataşehir";
            ogrenci6.Adresi.Mahalle = "Soli";
            ogrenci6.DersNotuEkle("Türkçe", 50);
            ogrenci6.DersNotuEkle("Matematik", 98);
            ogrenci6.DersNotuEkle("Fen", 43);
            ogrenci6.DersNotuEkle("Sosyal", 39);
            ogrenci6.Kitaplar.Add("Hayvan Çiftliği");

            Ogrenci ogrenci7 = new Ogrenci(4, "Kerem", "Akay", new DateTime(1997, 01, 25), CINSIYET.E, SUBE.A);
            ogrenci7.Adresi.Il = "İzmir";
            ogrenci7.Adresi.Ilce = "Karşıyaka";
            ogrenci7.Adresi.Mahalle = "Akdeniz";
            ogrenci7.DersNotuEkle("Türkçe", 14);
            ogrenci7.DersNotuEkle("Matematik", 86);
            ogrenci7.DersNotuEkle("Fen", 43);
            ogrenci7.DersNotuEkle("Sosyal", 64);
            ogrenci7.Kitaplar.Add("Frankenstein");

            Ogrenci ogrenci8 = new Ogrenci(5, "Hatice", "Çınar", new DateTime(2000, 02, 28), CINSIYET.K, SUBE.B);
            ogrenci8.Adresi.Il = "İzmir";
            ogrenci8.Adresi.Ilce = "Gaziemir";
            ogrenci8.Adresi.Mahalle = "Marmara";
            ogrenci8.DersNotuEkle("Türkçe", 2);
            ogrenci8.DersNotuEkle("Matematik", 11);
            ogrenci8.DersNotuEkle("Fen", 13);
            ogrenci8.DersNotuEkle("Sosyal", 74);
            ogrenci8.Kitaplar.Add("Jane Eyre");

            Ogrenci ogrenci9 = new Ogrenci(6, "Selim", "İleri", new DateTime(1992, 05, 15), CINSIYET.E, SUBE.B);
            ogrenci9.Adresi.Il = "İzmir";
            ogrenci9.Adresi.Ilce = "Gaziemir";
            ogrenci9.Adresi.Mahalle = "Ege";
            ogrenci9.DersNotuEkle("Türkçe", 70);
            ogrenci9.DersNotuEkle("Matematik", 5);
            ogrenci9.DersNotuEkle("Fen", 6);
            ogrenci9.DersNotuEkle("Sosyal", 0);
            ogrenci9.Kitaplar.Add("Büyük Umutlar");

            Ogrenci ogrenci10 = new Ogrenci(7, "Selin", "Kamış", new DateTime(1992, 10, 20), CINSIYET.K, SUBE.C);
            ogrenci10.Adresi.Il = "İzmir";
            ogrenci10.Adresi.Ilce = "Bayraklı";
            ogrenci10.Adresi.Mahalle = "Karadeniz";
            ogrenci10.DersNotuEkle("Türkçe", 19);
            ogrenci10.DersNotuEkle("Matematik", 81);
            ogrenci10.DersNotuEkle("Fen", 51);
            ogrenci10.DersNotuEkle("Sosyal", 1);
            ogrenci10.Kitaplar.Add("Bülbülü Öldürmek");
            Okul.Ogrenciler.Add(ogrenci1);
            Okul.Ogrenciler.Add(ogrenci2);
            Okul.Ogrenciler.Add(ogrenci3);
            Okul.Ogrenciler.Add(ogrenci4);
            Okul.Ogrenciler.Add(ogrenci5);
            Okul.Ogrenciler.Add(ogrenci6);
            Okul.Ogrenciler.Add(ogrenci7);
            Okul.Ogrenciler.Add(ogrenci8);
            Okul.Ogrenciler.Add(ogrenci9);
            Okul.Ogrenciler.Add(ogrenci10);
        }
        public static void AdresEkle()
        {
            Console.WriteLine("Öğrencinin Adresini Gir------------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ", Okul.Ogrenciler);
            Ogrenci o = Okul.Ogrenciler.Find(a => a.No == numara);
            Console.Write("Öğrencinin Adı Soyadı: " + o.Ad + " " + o.Soyad);
            Console.Write("Öğrencinin Şubesi: " + o.Sube);
            Console.WriteLine();
            o.Adresi.Il = araclar.MetinKontrol("Il:");
            o.Adresi.Ilce = araclar.MetinKontrol("Ilce:");
            o.Adresi.Mahalle = araclar.MetinKontrol("Mahalle:");
            Console.WriteLine();
            Console.WriteLine("Bilgiler sisteme girilmiştir.");
            AracGerecler.Bilgi();

        }
        public static void NotEkle()
        {
            Console.WriteLine("20-Not Gir-----------------------------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ", Okul.Ogrenciler);
            Ogrenci o = Okul.Ogrenciler.Find(a => a.No == numara);
            Console.Write("Öğrencinin Adı Soyadı: " + o.Ad + " " + o.Soyad);
            Console.Write("Öğrencinin Şubesi: " + o.Sube);
            string dersAdi = araclar.MetinKontrol("Eklemek istediğiniz dersi giriniz:");


            try
            {
                DersNotu dn = new DersNotu();
                int adet = int.Parse(Console.ReadLine());
                for (int i = 1; i <= adet; i++)
                {

                    dn.Not = araclar.SayiKontrol(i + " . Notu Girildi.");
                    dn.DersAdi = dersAdi;
                    o.Notlar.Add(dn);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hatalı giriş yapıldı tekrar deneyin.");
            }

        }
        public static void OgrenciEkle()
        {
            Console.WriteLine("15-Öğrenci Ekle -----------------------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ");
            string isim = araclar.MetinKontrol("Öğrencinin Adı: ");
            string soyisim = araclar.MetinKontrol("Öğrencinin soyadı: ");
            DateTime dogumTarihi = araclar.TarihKontrol("Öğrencinin dogum tarihi: ");
            CINSIYET cinsiyet = araclar.CinsiyetKontrol("Ögrencinin cinsiyeti (K/E):");
            SUBE sube = araclar.SubeKontrol("Ögrencinin subesi (A/B/C): ");

            okul.YeniOgrenciEkle(numara, isim, soyisim, dogumTarihi, cinsiyet, sube);






        }
        public static void OgrencininOkuduguKitabıEkle()
        {
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ------------------------------------");
            int numara = araclar.SayiKontrol("Öğrencinin numarası: ", Okul.Ogrenciler);
            Console.WriteLine();
            Ogrenci o = Okul.Ogrenciler.Find(a => a.No == numara);
            Console.Write("Öğrencinin Adı Soyadı: " + o.Ad + " " + o.Soyad);
            Console.Write("Öğrencinin Şubesi: " + o.Sube);
            Console.WriteLine();
            Console.Write("Eklenecek Kitabın Adı: ");
            string kitap = Console.ReadLine();
            o.KitapEkle(kitap);
            Console.WriteLine("Bilgiler sisteme girilmiştir.");
            AracGerecler.Bilgi();

        }
    }


}
