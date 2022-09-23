using System;

namespace PatikaHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (N >= 2 && N <= 5 && N % 2 == 0)
            {
                Console.WriteLine("Not Weird");

            }
            else if (N >= 6 && N <= 20 && N % 2 == 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N > 20 && N % 2 == 0)
            {
                Console.WriteLine("Not Weird");
            }

        }
    }
}
