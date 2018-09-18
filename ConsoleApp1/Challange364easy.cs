using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Challange364easy
    {
        private int Rolling (int rolls, int sides)
        {
            int result=0;
            int temp;
            Random rnd = new Random();
            for (int i = 0; i < rolls; i++)
            {
                temp = rnd.Next(1, sides);
                //Console.WriteLine($" // temp={temp}");
                result += temp;
            }
            return result;
        }

        public Challange364easy()
        {
            string[] input =
            {
                "5d12", "6d4", "1d2", "1d8", "3d6", "4d20", "100d100"
            };
            int[] array1 = {5,6,1,1,3,4,100};
            int[] array2 = {12,4,2,8,6,20,100};

            int rolls;
            int sides;
            int result;

            string inp = input[0];
             
            for (int i = 0; i < array1.Length; i++)
            {
                rolls = array1[i];
                sides = array2[i];
                Console.Write($"rolls={rolls} // sides={sides}");
                result = Rolling(rolls, sides);
                Console.WriteLine($" // result={result}");
            }
        }
        
    }
}
