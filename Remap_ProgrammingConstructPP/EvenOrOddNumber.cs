using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class EvenOrOddNumber
    {
        public static void EvenOrOdd(int n)
        {
            if (n % 2 == 0)
                Console.WriteLine("{0} is Even number", n);

            else
                Console.WriteLine("{0} is Odd number", n);
        }
    }
}
