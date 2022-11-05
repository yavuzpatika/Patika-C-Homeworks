﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen sayıya kadar tek olanları ekrana yazdırma
            Console.WriteLine("Lütfen Bir Sayı Girin;");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if(i%2==1) Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamı
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else ciftToplam += i;
            }
            Console.WriteLine("Tek toplam" + tekToplam);
            Console.WriteLine("Çift toplam" + ciftToplam);


            //break, continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                        break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }


        }

    }
}