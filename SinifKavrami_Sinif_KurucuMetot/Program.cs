using System;

namespace sinifkavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Söz Dizimi
             class SinifAdi
             {
                 [Erişim Belirleyici]  [Veri Tipi] OzellikAdi;
                 [Erişim Belirleyici]  [Geri Dönüş Tipi] Metotadi(Parametreler Listesi)
                 {
                  Metot Komutları
                 }
             }
                Erişim Beliryeciler
                * Public
                * Private
                * Internal
                * Protected
             */

            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Yavuz";
            calisan1.Soyad = "Karakoc";
            calisan1.No = 1;
            calisan1.Departman = "mühendis";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "ali";
            calisan2.Soyad = "veli";
            calisan2.No = 2;
            calisan2.Departman = "Ogretmen";

            calisan2.CalisanBilgileri();

            //Calisan calisan3 = new Calisan("ayşe", "Yilmaz", 333, "Hemşire");
            //calisan3.CalisanBilgileri();


            Calisan calisan4 = new Calisan("Mehmet", "Meler");
            calisan4.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad /*, int no, string departman*/)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            //this.No = no;
            //this.Departman = departman;
        }
        public Calisan()
        { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}"+ Ad);
            Console.WriteLine("Çalışanın Soyadı:{1}"+ Soyad);
            Console.WriteLine("Çalışanın Numarası:{2}"+ No);
            Console.WriteLine("Çalışanın Departmanı:{3}"+ Departman);
        }

    }
}