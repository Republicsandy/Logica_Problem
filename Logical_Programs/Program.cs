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
            Console.WriteLine("Press 2 for Perfect Number");
            Console.WriteLine("Press 3 for Prime Number");
            Console.WriteLine("Press 4 for Prime Number");
            Console.WriteLine("Press 5 for Coupon Numbers");
            Console.WriteLine("Press 6 for Stopwatch ");

            int valueGet = Convert.ToInt32(Console.ReadLine());
            
            switch(valueGet)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    break;
                case 4:
                    ReversNumber reversNumber = new ReversNumber();
                    break;
                case 5:
                    CouponNumber couponNumber = new CouponNumber();
                    break;
                case 6:
                    StopWatch stopwatch = new StopWatch();
                    break;
            }
        }
    }
}
