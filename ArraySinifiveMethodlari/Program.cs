using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("-------Sırasız Dizi------");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------Sıralı Dizi------");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("-------Array Clear------");
            // sayiDizisi elemanlarını kullanarak 4. indexten (5. eleman) itibaren 3 tane elemanı 0lar

            Array.Clear(sayiDizisi, 4, 3);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("-------Array Reverse------");
            // dizinin sırasını değiştirir  başı sona sonu başa getirir
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //İndexOf
            Console.WriteLine("-------Array IndexOf------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            //Resize
            Console.WriteLine("-------Array Resize------");
            // sayiDizisi boyutu 12 elemana çıkarıldı
            Array.Resize<int>(ref sayiDizisi,12);
            // sayiDizisi 9.cu elemanı 99 olarak atandı  boş elemanalar 0 olarak atandı
            sayiDizisi[8] = 99;

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }








            //Birthday Cake Candles ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //public static int birthdayCakeCandles(List<int> candles)
            //{
            //    int maxnums = candles.Max();
            //    int count = 0;

            //    foreach (int item in candles)
            //    {
            //        if (item == maxnums) count++;
            //    }
            //    return count;
            //}



            //Simple Array Sum ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //public static int simpleArraySum(List<int> ar)
            //{
            //    int toplam = 0;
            //    foreach (int item in ar)
            //    {
            //        toplam += item;
            //    }
            //    return toplam;
            //}

            //Day 7: Arrays ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //mantıken bu soruda dersten dolayı reverse methodunu kullanıp yapmamız lazım ama hata veriyor
            //soruyu visual studio da yapınca doğru ama hackerrankta çalıştırınca hata aldım

            //int[] arr = { 1, 4, 3, 2};
            //Array.Reverse(arr);
            //int length = arr.Count();
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            // ilkel yol ile çözünce hata vermiyor

            //int length = arr.Count();
            //for (int i = length - 1; i >= 0; i--)
            //{
            //    if (i != 0)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    else
            //    {
            //        Console.Write(arr[i]);
            //    }
            //}




            //A Very Big Sum ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //public static long aVeryBigSum(List<long> ar)
            //{
            //    long toplam = 0;
            //    foreach (int item in ar)
            //    {
            //        toplam += item;
            //    }
            //    return toplam;
            //}



            // Compare the Triplets ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //public static List<int> compareTriplets(List<int> a, List<int> b)
            //{
            //    List<int> skor = new List<int>() { 0, 0 };
            //    for (int i = 0; i < a.Count(); i++)
            //    {
            //        if (a[i] > b[i])
            //        {
            //            skor[0]++;
            //        }
            //        else if (a[i] < b[i])
            //        {
            //            skor[1]++;
            //        }
            //    }
            //    return skor;
            //}



            //Day 20: Sorting ÇÖZÜMÜ --------------------------------------------------------------------------------------------------

            //int[] a = { 3, 2, 1 };

            //var numberOfSwaps = 0;

            //for (var i = 0; i < a.Count(); i++)
            //{

            //    for (var j = 0; j < a.Count() - 1; j++)
            //    {
            //        if (a[j] > a[j + 1])
            //        {
            //            var temp = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = temp;
            //            numberOfSwaps++;
            //        }
            //    }
            //    if (numberOfSwaps == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            //Console.WriteLine($"First Element: {a[0]}");
            //Console.WriteLine($"Last Element: {a[a.Count() - 1]}");


            // Migratory Birds ÇÖZÜMÜ --------------------------------------------------------------------------------------------------



            //public static int migratoryBirds(List<int> arr)
            //{
            //    var birdTypeCounts = new int[arr.Count()];

            //    for (int i = 0; i < arr.Count(); i++)
            //    {
            //        birdTypeCounts[arr[i] - 1]++;
            //    }
            //    var maxBirdTypeCount = birdTypeCounts[0];
            //    var maxBirdType = 1;

            //    for (int i = 1; i < arr.Count; i++)
            //    {
            //        if (birdTypeCounts[i] > maxBirdTypeCount)
            //        {
            //            maxBirdTypeCount = birdTypeCounts[i];
            //            maxBirdType = i + 1;
            //        }

            //        if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
            //            maxBirdType = i + 1;
            //    }

            //    return maxBirdType;
            //}
        }

    }
}