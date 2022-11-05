using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim 
            renkler[0] = "Mavi";
            dizi[3] = 10;


            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngüler ve dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan bir örnek

            Console.Write("Lütfen eleman sayisini giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz", i + 1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıdizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);







            // Hacker Rank Çözümü

            int[] arr = { -4, 3, -9, 0, 4, 1 };

            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;
            var arraylength = arr.Count();

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] > 0)
                    positiveNumbers++;
                else if (arr[i] < 0)
                    negativeNumbers++;
                else
                    zeroNumbers++;
            }
           
            Console.WriteLine(Math.Round((double)positiveNumbers / arraylength, 6));
            Console.WriteLine(Math.Round((double)negativeNumbers / arraylength, 6));
            Console.WriteLine(Math.Round((double)zeroNumbers / arraylength, 6));
        }

    }
}