using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonDigit
{
    class Program
    {


        static void Main(string[] args)
        {

            int a;
            do
            {
                Console.WriteLine("Podaj liczbę elementów z przedziału 2-20");
                a = int.Parse(Console.ReadLine());
            }
            while (a < 2 || a > 20);

            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                var isValidElement = true;
                do
                {
                    Console.WriteLine(isValidElement ? $"Podaj { (i + 1)} element tablicy:" : $"Niepoprawna liczba, podaj { (i + 1)} element tablicy ponownie:");
                    isValidElement = int.TryParse(Console.ReadLine(), out int res);

                    arr[i] = res;
                }
                while (!isValidElement);
            }

            var arrayAsString = string.Join("", arr);
            var dict = new Dictionary<int, int>();

            for (int i = 0; i <= 9; i++)
            {
                var digit = i.ToString();
                var digitOccurs = arrayAsString.Count(x => x.ToString() == digit);
                dict.Add(int.Parse(digit), digitOccurs);
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