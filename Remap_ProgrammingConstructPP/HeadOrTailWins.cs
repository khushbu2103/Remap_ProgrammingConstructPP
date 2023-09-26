using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class HeadOrTailWins
    {
        public static void HeadOrTailWinsFor20Times()
        {
            Random random = new Random();
            int headsCount = 0;
            int tailsCount = 0;
            int totalFlips = 0;

            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(2); 
                if (flip == 0)
                {
                   // Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                   // Console.WriteLine("Tails");
                    tailsCount++;
                }
                totalFlips++;
            }
            Console.WriteLine($"Total flips: {totalFlips}");
            Console.WriteLine($"Heads count: {headsCount}");
            Console.WriteLine($"Tails count: {tailsCount}");

            if (headsCount == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }
    }
}
