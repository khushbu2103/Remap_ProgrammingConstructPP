using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class Factorial
    {
        public static void FactorialNumber(int numb) 
        {
            int factorial = 1;
            for(int i = 1; i <= numb; i++) 
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of {0} is : {1}", numb, factorial);
        }
    }
}
