using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class LargestNumber
    {
        public static void LargrtOfThreeNumber(double first, double second, double third)
        {
            if (first > second && first > third)
                Console.WriteLine("{0} is greater number", first);

            else if (second > first && second > third)
                Console.WriteLine("{0} is greater number", second);

            else if (third > first && third > second)
                Console.WriteLine("{0} is greater number", third);

            else
                Console.WriteLine("{0} {1} {2} are equal number", first, second, third);

        }
    }
}
