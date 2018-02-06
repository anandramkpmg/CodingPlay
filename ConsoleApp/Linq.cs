using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    public class Linq
    {
        public static void PrintEvenNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            var evenNumbers = from e in numbers
                where e % 2 == 0
                select e;

            foreach (var x in evenNumbers)
            {
                Console.WriteLine(x);
            }
        }

        public static void NumberAndSquare()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var square = numbers.Select(x => new
            {
                Number = x, Square = x * x
            });
            

            foreach (var x in square)
            {
                Console.WriteLine($"Number:" + x.Number + "\tSquare\t" + x.Square);
            }
        }

        public static void NumberAndFrequency()
        {
            int[] numbers = { 1, 2, 1, 4, 1, 2, 3, 3 };

            var freq = numbers.GroupBy(x => x).Select(g => new
            {
                Number = g.Key,
                Occurance = g.Count()
            });


            foreach (var x in freq)
            {
                Console.WriteLine($"Number:" + x.Number + "\t Occurences \t" + x.Occurance);
            }
        }

        public static void CharacterAndFrequency()
        {
            char[] chars = { 'a', 'a', 'b', 'c' };

            var freq = chars.GroupBy(x => x).Select(g => new
            {
                Number = g.Key,
                Occurance = g.Count()
            });


            foreach (var x in freq)
            {
                Console.WriteLine($"Number:" + x.Number + "\t Occurences \t" + x.Occurance);
            }
        }

        public static void MultiplyAndFactor()
        {
            int[] numbers = {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};

            var query = numbers.GroupBy(x => x).Select(g => new 
            {
                Number = g.Key,
                Multiply = g.Key * g.Count(),
                Frequency = g.Count()
            });

            foreach (var x in query)
            {
                Console.WriteLine(x.Number + "\t" + x.Multiply + "\t" + x.Frequency);
            }
        }

        public static void StartsAndEndWith()
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var query = cities.Where(x => x.StartsWith("A") && x.EndsWith("M"));

            foreach (var x in query)
            {
                Console.WriteLine(x);
            }
        }

        public static void Top3()
        {
            int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var top3 = numbers.OrderByDescending(x => x).Take(3);

            foreach (var x in top3)
            {
                Console.WriteLine(x);
            }
        }

        public static void UpperCase()
        {
            string str = "this IS a STRING";

            var uppercasewords = str.Split(' ').Where(w => w == w.ToUpper());

            Print(uppercasewords);
        }

        public static void ArrayToString()
        {
            string[] strArray = {"Cat", "Dog", "Rat"};

            var ssd = String.Join(",", strArray);

            Console.WriteLine(ssd);
        }

        public static void FileExtensionsCount()
        {
            string[] files = {"aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"};

            var grp = files.GroupBy(f => f.Split('.')[1].ToUpper());

            foreach (var g in grp)
            {
                Console.WriteLine(g.Key + '\t' + g.Count());
            }
        }

        private static void Print(IEnumerable<string> array)
        {
            foreach (var x in array)
            {
                Console.WriteLine(x);
            }
        }
}
}

