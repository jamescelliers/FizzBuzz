using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    //Write a program that prints the numbers from 1 to 100.
    //For multiples of three print “Fizz” instead of the number.
    //For the multiples of five print “Buzz”.
    //For numbers which are multiples of both three and five print “FizzBuzz”."
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                string lineString = "";

                if (i % 3 == 0)
                {
                    lineString += "Fizz";
                }
                if (i % 5 == 0)
                {
                    lineString += "Buzz";
                }
                if (lineString == "")
                {
                    lineString = i.ToString();

                }
                Console.WriteLine(lineString);
            }
            Console.Read();
        }
    }
}
