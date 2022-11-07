using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde
             * saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

            ArrayList arraySesliharfler = new ArrayList();

            string sesliHarfler = "aeıioöuü";

            Console.Write("Cümle giriniz:");
            string girilenCumle = Console.ReadLine();

            for (int i = 0; i < girilenCumle.Length; i++)
            {
                // arrayimiz sesli harf içeriyor mu diye kontrol ediyoruz
                // cümlede geçen sesli harfleri 1 er  defa alıyoruz  3 tane a var ise tek a alınıyor
                if (sesliHarfler.Contains(girilenCumle[i]) && !arraySesliharfler.Contains(girilenCumle[i]))
                {
                    arraySesliharfler.Add(girilenCumle[i]); // diziye ekleme
                }
            }

            arraySesliharfler.Sort(); // alfabetik sıralama yapıyoruz
            Console.WriteLine("yazdığımız cümledeki kullanılan sesli harfler");
            foreach (var item in arraySesliharfler) // ekrana yazdırma
            {
                Console.WriteLine(item);
            }
        }
    }
}
