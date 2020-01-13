using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
            public static bool samearray(int[] arr1, int[] arr2)
            {
                int a = arr1.Length;
                int b = arr2.Length;
            
                if (a != b)
                    return false;

                Array.Sort(arr1);
                Array.Sort(arr2);
            
                for (int i = 0; i < a; i++)
                    if (arr1[i] != arr2[i])
                        return false;
                
                return true;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Zadeklaruj rozmiar tablicy");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Zadeklaruj rozmiar tablicy drugiej");
                int a = int.Parse(Console.ReadLine());

                int[] arr1 = new int[b];
                int[] arr2 = new int[a];
            
                if (b != a)
                {
                    Console.WriteLine("Rozmiary tablic różnią się");
                    Console.ReadKey();
                return;
                }

                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine($"Podaj { (i + 1)} element tablicy pierwszej:");
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine($"Podaj { (i + 1) } element tablicy drugiej:");
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i]);
                }
                Console.WriteLine();

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i]);
                }
                Console.WriteLine();
                if (samearray(arr1, arr2))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                Console.ReadKey();
            }
        }
    }