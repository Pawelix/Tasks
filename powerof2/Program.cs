using System;

namespace powerof2
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Podaj ilosc liczb: ");
                int a = int.Parse(Console.ReadLine());

                int[] arr = new int[a];

                for (int b = 0; b < arr.Length; b++)
                {
                    Console.WriteLine($"Podaj { (b + 1) } liczbe: ");
                    arr[b] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                int result = 0;
                foreach (int x in arr)
                {
                    result |= x;
                };

                for (int i = 0; i < 32; i++)
                {
                    int power = 1 << i;
                    if ((result & power) != 0)
                    {
                        Console.Write($" { power } ,");
                    }
                }

                Console.ReadKey();
            }
        }
    }