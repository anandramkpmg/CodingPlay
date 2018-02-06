using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPlay
{
    static class CodeWar
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }

        public static int DescendingOrder(int num)
        {
            //1341
            var numstring = num.ToString();

           return int.Parse(String.Concat(num.ToString().ToCharArray().OrderByDescending(x => x)));
        }

        public static string SubtractSum(int number)
        {

            if (number < 0 || number > 10000) { return "Not valid number"; }

            var originalNumber = number;

            var chars = number.ToString().ToCharArray();

            int sum = 0;
            var r = 0;

            while (number != 0)
            {
                r = number % 10;
                number = number / 10;
                sum = sum + r;
            }

            var difference = originalNumber - sum;

            if (difference <= 100)
            {
                return "found";
            }
            else
            {
                SubtractSum(difference);
            }

            
            return "";
        }

        public static List<int> Solve(List<int> arr)
        {
            //Kata.Solve(new List<int> {15,11,10,7,12}) => new List<int> {15,7,12,10,11}
            //var input = new List<int> {15, 11, 10, 7, 12};

            arr.Sort();
            
            var output = new List<int>();

            while (arr.Count != 0)
            {
                if (arr.Any())
                {
                    var max = arr.Max();
                    var index = arr.IndexOf(max);
                    arr.RemoveAt(index);
                    output.Add(max);
                }

                if (arr.Any())
                {
                    var min = arr.Min();
                    var index1 = arr.IndexOf(min);
                    arr.RemoveAt(index1);
                    output.Add(min);
                }
            }

            return output;
        }
    }
}
