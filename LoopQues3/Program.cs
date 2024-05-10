using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQues3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number");
            int number =Convert.ToInt32(Console.ReadLine());
            int factorial=findFactorial(number);
            Console.WriteLine($"Factorial of {number} is - {factorial}");

        }

        public  static int findFactorial(int number)
        {
            int fact = 1;
            for(int i=1;i<=number;i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
