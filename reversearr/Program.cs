using System;
using System.Text.RegularExpressions;

namespace reversearr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy:");
            int arrsize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrsize];

            for (int i = 0; i < arrsize; i++)
            {
                Console.WriteLine($"Podaj { (i + 1) } element tablicy:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arrsize);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();

            for (int i = arr.Length; i > 0; i--)
            {
                Console.Write(arr[i - 1]);
            }
            Console.ReadLine();
        }
    }
}
