using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi
             * bulan, her iki grubun kendi içerisinde ortalamalarını alan ve
             * bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */

            int sayi = 0;
            ArrayList girilenSayilar = new ArrayList();

            Console.WriteLine("20 adet pozitif sayı giriniz.");
            int count = 1;
            for (int i = 0; i < 8; i++)
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
            int nbolum = 3;
            girilenSayilar.Sort(); // sayıları kücükten büyüğe doğru sıraladık
            ArrayList min3sayi = new ArrayList();
            int min3sayitoplam = 0;
            for (int i = 0; i < 3; i++)
            {
                min3sayi.Add(girilenSayilar[i]);
            }
            Console.WriteLine("en küçük 3 sayi");
            foreach (int i in min3sayi)
            {
                min3sayitoplam += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("En küçük 3 sayının ortalaması : " + min3sayitoplam / 3);

            girilenSayilar.Reverse();  // sayıları ters çevirerek büyükten küçüğe doğru sıraladık
            ArrayList max3sayi = new ArrayList();
            int max3sayitoplam = 0;

            for (int i = 0; i < 3; i++)
            {
                max3sayi.Add(girilenSayilar[i]);
            }



            foreach (int i in max3sayi)
            {
                max3sayitoplam += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("En büyük 3 sayının ortalaması : " + max3sayitoplam / 3);

            int ortToplam = (max3sayitoplam / 3) + (min3sayitoplam / 3);
            Console.WriteLine("En küçük sayıların ortalaması ve en büyük sayıların ortalamaları toplamı :" + ortToplam);
        }
    }
}