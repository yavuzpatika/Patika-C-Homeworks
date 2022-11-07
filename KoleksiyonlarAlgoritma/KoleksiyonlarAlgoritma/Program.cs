using System;
using System.Collections;
using System.Collections.Generic;

namespace PatikaHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
                • Negatif ve numeric olmayan girişleri engelleyin.
                • Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                • Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
             */

            int sayi = 0;
            ArrayList girilenSayilar = new ArrayList();

            Console.WriteLine("20 adet pozitif sayı giriniz.");
            int count = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}.sayıyı giriniz: ");
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi > 0)
                    {
                        count++;
                        girilenSayilar.Add(sayi);
                    }
                    else // negatif degerse uyarı veriyor
                    {
                        i = i - 1;
                        Console.WriteLine("Negatif değer giremezsini Lütfen Pozitif bir tam sayı değeri giriniz");
                    }
                }
                catch (Exception) // sayı dışında başka karakter girerse uyarı veriyor
                {
                    i = i - 1;
                    Console.WriteLine("Lütfen Yalnızca Sayısal  bir deger giriniz.");
                }
            }

            ArrayList asalsayilar = new ArrayList();             //Asal
            ArrayList asalolmayansayilar = new ArrayList();      // Asal olmayan


            bool status = false;
            foreach (int item in girilenSayilar)
            {
                status = false;
                for (int x = 2; x <= item / 2; x++)//Aldığımız sayı asal mı degil mi bulmak için bir döngü tanımlıyoruz ve o sayının yarısı kadar döngü dönüyor.
                {
                    if (item % x == 0)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == true || item == 1)
                    asalolmayansayilar.Add(item);
                else
                    asalsayilar.Add(item);
            }

            int average = 0;
            asalsayilar.Sort();// sıralama
            Console.WriteLine("\n *** Asal Sayılar *** ");
            foreach (int item in asalsayilar)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal sayı dizisinin eleman sayısı: {asalsayilar.Count} - Ortalama: {average / asalsayilar.Count}\n");



            asalolmayansayilar.Sort();// sıralama
            average = 0;
            Console.WriteLine("\n *** Asal Olmayan Sayılar *** ");
            foreach (int item in asalolmayansayilar)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal olmayan sayı dizisinin eleman sayısı: {asalolmayansayilar.Count} - Ortalama: {average / asalolmayansayilar.Count}");
        }
    }
}
