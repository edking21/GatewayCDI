//
// Description: 
//    Print the number 1-100. 
//    For multiples of 3, print “Fizz”
//    For multiples of 5, print “Buzz”
//    For multiples of 3 and 5, print “FizzBuzz”.

using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
