using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2016, 1, 1);
            var now = DateTime.Now;
            Console.WriteLine(now);
            var today= DateTime.Today;
            //Console.WriteLine(today);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.Second);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH-mm"));
            var timespan = new TimeSpan();
            
                






            //Console.WriteLine(now.ToString());

        }
    }
}
