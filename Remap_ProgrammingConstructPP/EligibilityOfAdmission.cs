using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class EligibilityOfAdmission
    {
        public static void EligibilityOfAdmissionBasedOnMarkes(double marksInMath, double marksInChemistry, double marksInPhysics)
        {
            //bool eligibility = false;
            //double sum = marksInMath + marksInChemistry + marksInPhysics;
            if (marksInMath >= 65 && marksInChemistry >= 50 && marksInPhysics >= 55 && (marksInMath + marksInChemistry + marksInPhysics) >= 180)
                Console.WriteLine("Candidate is eligible for admission");

            else if ((marksInMath + marksInChemistry) >= 140 || (marksInMath + marksInPhysics) >= 140) 
                Console.WriteLine("Candidate is eligible for admission");

            else
                Console.WriteLine("Candidate in not eligible");

        }
    }
}
