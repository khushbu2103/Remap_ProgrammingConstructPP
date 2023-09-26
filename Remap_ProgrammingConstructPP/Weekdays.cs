using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class Weekdays
    {
        public static void WeekdayNumberAndName()
        {
            Console.Write("Enter weekday number (1-7): ");
            int weekdayNumber = Convert.ToInt32(Console.ReadLine());

            string weekdayName;
            switch (weekdayNumber)
            {
                case 1:
                    weekdayName = "Monday";
                    break;
                case 2:
                    weekdayName = "Tuesday";
                    break;
                case 3:
                    weekdayName = "Wednesday";
                    break;
                case 4:
                    weekdayName = "Thursday";
                    break;
                case 5:
                    weekdayName = "Friday";
                    break;
                case 6:
                    weekdayName = "Saturday";
                    break;
                case 7:
                    weekdayName = "Sunday";
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    return;
            }

            Console.WriteLine("The name of the weekday is : {0}", weekdayName);
        }
    }
}
