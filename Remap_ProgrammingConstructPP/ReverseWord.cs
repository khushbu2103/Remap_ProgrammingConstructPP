using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_ProgrammingConstructPP
{
    internal class ReverseWord
    {
        public static void ReverseWordByWhile(string word)
        {
            string reverse = "";
            int i = word.Length - 1;
            while (i >= 0)
            {
                reverse += word[i];
                i--;
            }

            Console.WriteLine("Reversed word: " + reverse);
        }
    }
}
