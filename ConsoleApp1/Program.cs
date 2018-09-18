using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Display(string s)
        {
            Console.WriteLine("Welcome form inside of Display()");
            Console.WriteLine(s);
        }

        static void DisplayABC (int a, int b, int c)
        {
            Console.WriteLine($"a={a} // b={b} // c={c}");
        }

        static void TestABC()
        {
            // initializing variables
            int a = 5;
            int b = 6;
            int c = a;
            DisplayABC(a, b, c);

            // change staitment
            a = b;
            DisplayABC(a, b, c);

            // change staitment
            b = 7;
            DisplayABC(a, b, c);
        }

        static void Main(string[] args)
        {
            //String testText = "Hello, it's first C# program by h4sski";
            //Display(testText);
            //TestABC();
            //new OtherClass();

            //new Challange364easy(); // missplelling in the name of file :P
            new Challenge363Easy();


            Console.ReadKey();
        }
    }
}
