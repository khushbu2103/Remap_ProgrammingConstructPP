using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("Choose any program");
                Console.WriteLine("1. Two integers are equals or not\n" +
                    "2. Even 0r odd number\n" +
                    "3. Eligible age for voting\n" +
                    "4. Largest of three number\n" +
                    "5. Eligibility of admission based on marks\n" +
                    "6. Weekday number and name\n" +
                    "7. Some arithmetic operations\n" +
                    "8. Power of 2\n" +
                    "9. Sum of square of number\n" +
                    "10. Factorial number\n" +
                    "11. Head or tail win\n" +
                    "12. Reverse words\n" +
                    "13. Sum of first 5 natural number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter 1st number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        TwoIntegerEqualsOrNot.TwoNumbers(num1, num2);


                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision1 = Convert.ToInt32(Console.ReadLine());
                        if (decision1 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter any number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        EvenOrOddNumber.EvenOrOdd(n);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision2 = Convert.ToInt32(Console.ReadLine());
                        if (decision2 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter any number");
                        double age = Convert.ToDouble(Console.ReadLine());
                        EligibleAge.EligibleAgeOfCandidate(age);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision3 = Convert.ToInt32(Console.ReadLine());
                        if (decision3 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter three numbers");
                        double first  = Convert.ToDouble(Console.ReadLine());
                        double second = Convert.ToDouble(Console.ReadLine());
                        double third = Convert.ToDouble(Console.ReadLine());
                        LargestNumber.LargrtOfThreeNumber(first, second, third);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision4 = Convert.ToInt32(Console.ReadLine());
                        if (decision4 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Input the marks obtained in Mathematics");
                        double marksInMath = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the marks obtained in Chemistry");
                        double marksInChemistry = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the marks obtained in Physics");
                        double marksInPhysics = Convert.ToDouble(Console.ReadLine());
                        EligibilityOfAdmission.EligibilityOfAdmissionBasedOnMarkes(marksInMath, marksInChemistry, marksInPhysics);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision5 = Convert.ToInt32(Console.ReadLine());
                        if (decision5 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 6:
                        Weekdays.WeekdayNumberAndName();

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision6 = Convert.ToInt32(Console.ReadLine());
                        if (decision6 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 7:
                        ArithmeticOperations.SomeArithmeticOperation();

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision7 = Convert.ToInt32(Console.ReadLine());
                        if (decision7 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Enter any number in between 1 & 31");
                        int x = Convert.ToInt32(Console.ReadLine());
                        PowerOf2.PowerOfTwo(x);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision8 = Convert.ToInt32(Console.ReadLine());
                        if (decision8 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 9:
                        Console.Write("Enter a number: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        SumOfSquare.SumOfSquareOfNumber(N);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision9 = Convert.ToInt32(Console.ReadLine());
                        if (decision9 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 10:
                        Console.Write("Enter a number: ");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        Factorial.FactorialNumber(numb);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision10 = Convert.ToInt32(Console.ReadLine());
                        if (decision10 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 11:
                        HeadOrTailWins.HeadOrTailWinsFor20Times();

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision11 = Convert.ToInt32(Console.ReadLine());
                        if (decision11 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 12:
                        Console.WriteLine("Enter a word:");
                        string word = Convert.ToString(Console.ReadLine());
                        ReverseWord.ReverseWordByWhile(word);

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision12 = Convert.ToInt32(Console.ReadLine());
                        if (decision12 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 13:
                        SumOfNaturalNumber.SumOfFirst5Number();

                        Console.WriteLine("\nWould you like to contine press (1) or exit press (0)");
                        int decision13 = Convert.ToInt32(Console.ReadLine());
                        if (decision13 == 0)
                        {
                            execute = false;
                        }
                        break;
                }


            }
        }
    }
}
