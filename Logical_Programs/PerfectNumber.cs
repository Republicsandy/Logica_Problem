using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    class PerfectNumber
    {
        public PerfectNumber()
        {
            Console.WriteLine("Enter the number \n");
            int getValueByUser = Convert.ToInt32(Console.ReadLine());
            int counter =1, addition = 0;
            while (counter < getValueByUser)
            {
                if(getValueByUser % counter == 0)
                {
                    addition = addition + counter;
                }
                counter++;
            }
            if (addition == getValueByUser)
            {
                Console.WriteLine("{0} is Perfect Number", getValueByUser);
            }else
            {
                Console.WriteLine("{0} is not a Perfect Number", getValueByUser);
            }
        }

    }
}
