using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class SumOfSquare
    {
        public static void SumOfSquareOfNumber(int N)
        {
            int sum = 0; 

            for (int i = 1; i <= N; i++)
            {
                sum += i * i;
            }

            Console.WriteLine("The sum of squares of the first " + N + " numbers is: " + sum);
        }
    }
}
