using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class TwoIntegerEqualsOrNot
    {
        public static void TwoNumbers(int num1, int num2)
        {
            if (num1 == num2)
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            else
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
        }

    }
}
