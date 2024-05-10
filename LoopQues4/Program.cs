using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopQues4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secrectNumber = 5;
            for(int i = 0;i<4;i++)
            {
                Console.WriteLine("Please Enter value between 1 to 10");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == secrectNumber)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else if (i < 3) {

                    Console.WriteLine("Try Again");
                        }
                else
                {
                    Console.WriteLine("You Lost");
                }
                
            }
        }
    }
}
