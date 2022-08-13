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
            Console.WriteLine("Enter number for finding the series");

            int number =Convert.ToInt32(Console.ReadLine());
            int valueInFirstNumber = 0, valueInSecondNumber = 1, valueInThirdNumber = 2;
            
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(valueInFirstNumber + " ");

                valueInThirdNumber = valueInFirstNumber + valueInSecondNumber;
                valueInFirstNumber = valueInSecondNumber;
                valueInSecondNumber = valueInThirdNumber;
            }
        }
    }
}
