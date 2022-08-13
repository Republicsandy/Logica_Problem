using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome To Logical Problem Series");
            Console.WriteLine("Please Enter the Number Which Program you want to Perform");
            Console.WriteLine("Press 1 for Fibonacci");

            int valueGet = Convert.ToInt32(Console.ReadLine());
            
            switch(valueGet)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    break;
            }
        }
    }
}
