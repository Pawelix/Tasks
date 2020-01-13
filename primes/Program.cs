using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbę poczatkową przedzialu");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Wprowadz liczbę końcową przedzialu");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((a < 1) || (b < 1) || (a > b) || (b > 1000000000) || ((b - a) > 1000000000))
            {
                Console.Write("Koniec przedziału jest mniejszy od początku");
                Console.ReadKey();
                return;
            }

            bool prime = true;
            int result = 0;
            int c;

            for (int i = a; i <= b; i++)
            {
                for (c = 2; c < i; c++)
                {
                    if (i % c == 0)
                    {
                        prime = false;
                    }
                }
                if ((prime == true) && (i > 1))
                {
                    Console.WriteLine($"{ + i} Jest liczbą pierwszą");
                    result++;
                }
                else prime = true;
            }

            Console.WriteLine($"W przedziale od { a } do { b } jest: { result} liczb pierwszych");
            Console.ReadKey(); 
        }
    }
}