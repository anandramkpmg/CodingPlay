using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class SampleClass
    {
        public int SumOfElements(int[] numbers)
        {
            return numbers.Sum(x => x);
        }

        public static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int alcieScore = 0, bScore = 0;

            if (a0 > b0)
            {
                alcieScore++;
            }
            else if (a1 > b1)
            {
                alcieScore++;
            }
            else if(a2 > b2)
            {
                alcieScore++;
            }

            if (b0 > a0)
            {
                bScore++;
            }
            else if (b1 > a1)
            {
                bScore++;
            }
            else if (b2 > a2)
            {
                bScore++;
            }


            return new int[] {alcieScore, bScore};
        }
    }
}
