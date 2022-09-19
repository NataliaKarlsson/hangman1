using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            Console.Clear();
            var str = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                str.Append('_');
            }

            for (var i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                Console.Write(' ');
            }
            Console.WriteLine();

            var letters = new List<string>();
            var count = 0;
            while (count < 10)
            {
                Console.WriteLine();

                var letter = Console.ReadLine().ToUpper();
                bool hasLetter = true;
                for (var i = 0; i < str.Length; i++)
                {
                    if (letter == input[i].ToString())
                        str[i] = input[i];
                    hasLetter = false;
                }
                if (!hasLetter)
                {
                    count++;
                    letters.Add(letter);
                }

                Console.WriteLine();
                for (var i = 0; i < str.Length; i++)
                {
                    Console.Write(str[i]);
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
            Console.WriteLine("wrong letters: ");
            foreach (var e in letters)
            {

                Console.Write(e + " ");
            }


        }

    }
}