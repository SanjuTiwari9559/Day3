using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQues5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter commoa separated numbers: ");
            var series=(Console.ReadLine());
            var numbers=series.Split(',');
            int max = int.Parse(numbers[0]);
            foreach(var number in numbers) { 
                int number1=Convert.ToInt32(number);
                if(number1>max) {
                    max = number1;
                }
            
            }
            Console.WriteLine($"Max of {series} is {max}");

        }
    }
}
