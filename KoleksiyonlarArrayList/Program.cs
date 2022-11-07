using System;
using System.Collections;
using System.Collections.Generic;

namespace PatikaHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listkarisik = new ArrayList();

            //listkarisik.Add("Yavuz");
            //listkarisik.Add(77);
            //listkarisik.Add(true);
            //listkarisik.Add('A');

            //Console.WriteLine(listkarisik[1]);

            //foreach (var item in listkarisik)
            //{
            //    Console.WriteLine(item);
            //}


            //AddRange
            Console.WriteLine("------ Add Range ------");
            //string[] renkler = { "kırmızı", "mavi", "pembe", "mor" };
            List<int> sayılar = new List<int>() { 1, 9, 8, 5, };
            //listkarisik.AddRange(renkler);
            listkarisik.AddRange(sayılar);

            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("------ Sort ------");
            listkarisik.Sort();
            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("------ Binary Search ------");
            Console.WriteLine(listkarisik.BinarySearch(9));


            //Reverse
            Console.WriteLine("------ Reverse ------");
            listkarisik.Reverse();

            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("------ Clear ------");
            listkarisik.Clear();
            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }
        }
    }
}
