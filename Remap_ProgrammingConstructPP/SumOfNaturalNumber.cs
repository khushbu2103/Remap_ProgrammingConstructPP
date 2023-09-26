using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class SumOfNaturalNumber
    {
        public static void SumOfFirst5Number()
        {
            int i = 1, num = 5, sum = 0;
            while (i <= num)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of first " + num + " natural numbers = " + sum);
        }
    }
}
