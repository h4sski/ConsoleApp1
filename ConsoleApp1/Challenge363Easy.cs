using System;
using System.IO;
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

            /*
             * BONUS 
             */

            // reading local file
            string path = @"E:\#cloud\OneDrive\programingCsharp\testing\ConsoleApp1\ConsoleApp1\enable1.txt";
            using (StreamReader file = File.OpenText(path))
            {
                Console.WriteLine("start of reading file");
                string line = "";
                int count = 0;
                //for (int i=0; i<10; i++)  // check if and how file is reading
                //{
                //    line = file.ReadLine();
                //    Console.WriteLine(line);
                //}
                while ((line = file.ReadLine()) != null)
                {
                    if (check(line)) count++;
                }
                Console.WriteLine("The answer is: "+count);
            }
        }

        // checking method
        private bool check(string s)
        {
            bool result=true;
            if (s.Length < 3) return result;

            if (s.Contains("ei") && !s.Contains("cei")
                ||
                s.Contains("ie") && s.Contains("cie"))
            {
                result = false;
            } else if (!s.Contains("ei") || !s.Contains("ie"))
            {
                result = false;
            }

            //if (s.Contains("ie"))
            //{
            //    result = true;
            //    if (s.Contains("cie")) result = false;
            //}
            return result;
        }
    }
}
