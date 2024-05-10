using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQues2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool countinue = true;
            int totalSum = 0;
            while(true)
            {
                Console.WriteLine("enter a number or ok to exit.");
                var input= Console.ReadLine();
                if(input.ToUpper() == "OK")
                {
                    break;
                }
                var number= Convert.ToInt32(input);
                totalSum += number;

            }
            Console.WriteLine($"Total sum of the previous number is - {totalSum}");
        }
    }
}
