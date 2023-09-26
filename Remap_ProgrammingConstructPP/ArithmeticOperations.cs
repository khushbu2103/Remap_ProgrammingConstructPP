using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class ArithmeticOperations
    {
        public static void SomeArithmeticOperation()
        {
            Console.WriteLine("Choose any program");
            Console.WriteLine("1. Addition\n 2. Substraction\n 3. Multiplication\n 4.Division");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter 2 numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int y = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y;
                    Console.WriteLine("Addition of {0} and {1} is : {2}", x, y, sum);
                    break;
                case 2:
                    Console.WriteLine("Enter 2 numbers");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int difference = Math.Abs(num1 - num2);
                    Console.WriteLine("Difference of {0} and {1} is : {2}", num1, num2, difference);
                    break;
                case 3:
                    Console.WriteLine("Enter 2 numbers");
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int multiple = first * second;
                    Console.WriteLine("Difference of {0} and {1} is : {2}", first, second, multiple);
                    break;
                case 4:
                    Console.WriteLine("Enter 2 numbers");
                    float n1 = float.Parse(Console.ReadLine());
                    float n2 = float.Parse(Console.ReadLine());
                    float division = (n1 / n2);
                    Console.WriteLine("Division of {0} and {1} is : {2}", n1, n2, division);
                    break;

            }
        }
    }
}
