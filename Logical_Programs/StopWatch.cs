using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class StopWatch
    {
        public StopWatch()
        {
            Console.WriteLine("Enter to Start the Stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("Enter to Stop the Stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elapsed time = " + (stop - start));
        }
    }
}
