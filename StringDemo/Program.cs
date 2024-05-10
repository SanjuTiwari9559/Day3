using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "This is Sanjay Tiwari He is hard working person that why he is doing very well";
            string text = "This is Sanjay ";
           // Console.WriteLine(ContinueMessage.showString(text));
            //String Builder Practice
            var stringBuilder=new StringBuilder();
            stringBuilder.Append("Sanjay");
            Console.WriteLine(stringBuilder);
            stringBuilder.Remove(0, 2);
            Console.WriteLine(stringBuilder);
            char[] ch = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            stringBuilder.Append(ch);
            Console.WriteLine(stringBuilder);
            stringBuilder.Replace('a', 'z');
            Console.WriteLine(stringBuilder);





        }
    }
}
