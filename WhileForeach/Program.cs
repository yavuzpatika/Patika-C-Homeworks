using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayıp console den girilen sayıya kadar olan sayıların ortalaması
            Console.Write("Lütfen Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a dan z ye kadar tüm harfleri konsola yazdırma
            char character = 'a';
            while (character<'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine(" ***** Foreach *****");
            string[] arabalar = { "BMW", "Ford", "Renault", "Wolsvagen" };
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }

        }

    }
}