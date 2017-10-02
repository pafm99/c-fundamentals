using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop that prints 1 to 100
            for (int num = 1; num <= 100; num++)
            {
                if(!(num % 15 == 0))
                {
                    if(num % 3 == 0 || num % 5 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                
            }
            ///fizz buzz
            for (int num = 1; num < 101; num++)
            {
                if(num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                   Console.WriteLine("Buzz");
                }
            }
        }
    }
}
