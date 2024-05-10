using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQues1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int number = 100;
            int count=countDivByThree(number);
            Console.WriteLine($"Number of count devided by 3 is - {count}");
        }

        public static int countDivByThree(int number)
        {
           int count=0;
            for (int i = 2; i < number; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
