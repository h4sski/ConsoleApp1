using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://www.reddit.com/r/dailyprogrammer/comments/8q96da/20180611_challenge_363_easy_i_before_e_except/ 
 */

namespace ConsoleApp1
{
    class Challenge363Easy
    {
        // constructor method
        public Challenge363Easy()
        {
            // set input words
            string[] input = {
                "a",
                "zombie",
                "transceiver",
                "veil",
                "icier"
            };

            //for (int i=0; i<3; i++) {
            foreach (string inp in input)
            {
                //Console.WriteLine(input[i]);
                Console.Write(inp + " // ");
                Console.WriteLine(check(inp));
            }
        }

        // checking method
        private bool check(string s)
        {
            bool result=true;
            if (s.Length < 3) return result;
            if (s.Contains("ei") && !s.Contains("cei"))
            {
                result = false;
            } else if (s.Contains("cie"))
            {
                result = false;
                if (s.Contains("ie")) result = true;
            }
            return result;
        }
    }
}
