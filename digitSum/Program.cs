using System;
using System.Collections.Generic;
using System.Linq;

namespace digitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę elementów w tablicy");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                var isValidElement = true;
                do
                {
                    Console.WriteLine(isValidElement ? $"Podaj { (i + 1)} element tablicy:" : $"Niepoprawna liczba, podaj {i + 1} element tablicy ponownie:");
                    isValidElement = int.TryParse(Console.ReadLine(), out int res);

                    arr[i] = res;
                }
                while (!isValidElement);
            }

            //var arrayAsString = string.Join("", arr);
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var number = arr[i];
                var digitSum = number.ToString().ToList().Sum(x=>x);
                dict.Add(i, digitSum);
            }

            var maxOccursDigits = dict.Where(x => x.Value == dict.Values.Max()).ToDictionary(p => p.Key, p => p.Value);

            var maxOccursDigit = maxOccursDigits.Count() == 1 ?
                maxOccursDigits.First().Key :
                maxOccursDigits.First(x => x.Key == maxOccursDigits.Keys.Max()).Key;

            Console.WriteLine("Wynik:");
            Console.WriteLine(maxOccursDigit);

            Console.ReadKey();
        }
    }
}