using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    class PrimeNumber
    {
        public PrimeNumber()
        {
            Console.WriteLine("Enter number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;
            for (int counter = 1; counter <= number; counter++)
            {
                if  (number % counter == 0)
                {
                    divisors++;
                }
            }
            if (divisors == 2)
            {
                Console.WriteLine("The enter number is a prime number");
            }else
            {
                Console.WriteLine("The number is not a prime");
            }
        }
    }
}
