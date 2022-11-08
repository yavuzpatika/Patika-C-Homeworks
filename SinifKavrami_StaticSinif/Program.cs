﻿using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Merve", "Yidiz", "IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Yıldız", "Seher", "IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan3 = new Calisan("Gökçe", "Kara", "IT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Çıkarma işlemi Sonucu:{0}", Islemler.Çıkar(170, 20));
            Console.WriteLine("Toplama işlemi Sonucu:{0}", Islemler.Topla(70, 30));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}