using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class PowerOf2
    {
        public static void PowerOfTwo(int n)
        {
            if (n < 0 || n >= 31)
            {
                Console.WriteLine("n must be between 0 and 30:");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"2^" + i + " = " + Math.Pow(2, i));

            }
        }
    }
}
