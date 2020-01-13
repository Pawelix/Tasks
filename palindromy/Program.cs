using System;
using System.Text.RegularExpressions;

namespace palindromy
{
        class Program
        {
            static void Main(string[] args)
            {
                string word;
                string reverseword = "";

                Console.WriteLine("Podaj słowo:");
                word = Console.ReadLine();

                Regex rgx = new Regex("[^a-zA-Z]");
                string temp = rgx.Replace(word, "");



                for (int i = temp.Length - 1; i >= 0; i--)
                {
                    reverseword += temp[i];
                }

                if (temp == reverseword)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                Console.ReadKey();
            }
        }
    }
