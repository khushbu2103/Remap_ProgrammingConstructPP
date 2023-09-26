using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class EligibleAge
    {
        public static void EligibleAgeOfCandidate(double age)
        {
            if (age >= 18)
                Console.WriteLine("Candidate is eligible for voting");

            else
                Console.WriteLine("Candidate is not eligible for voting");
        }
    }
}
