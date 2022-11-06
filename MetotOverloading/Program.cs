﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar deneme = new Metotlar();
            deneme.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Overloading - Aşırı yükleme
            int ifade = 888;
            deneme.EkranaYazdir(Convert.ToString(ifade));
            deneme.EkranaYazdir(ifade);
            deneme.EkranaYazdir("Yavuz", "Karakoç");
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}