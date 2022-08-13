using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
     class FibonacciSeries
    {
        public FibonacciSeries()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber , counterValue = 2, rangeOFNumber;

            Console.WriteLine("Please Enter Range of Fibonacci series:");
            rangeOFNumber = Convert.ToInt32(Console.ReadLine());
            if(rangeOFNumber < 2)
            {
                Console.WriteLine("Please enter a number greater than 2");
            }else{
                Console.WriteLine(firstNumber + " " + secondNumber + " ");
                while (counterValue <= rangeOFNumber)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.WriteLine("Range of numbers are" + " " + nextNumber );
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;

                    counterValue++;

                }
            }
        }
    }
}
