using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    public  class ContinueMessage
    {
        public static string showString(string message)
        {
            int  maxLength = 20;
            var outputMessages=message.Split(' ');
            List<string> outputList=new List<string>();
            int countiMessLen=0;
            if(message.Length > maxLength)
            {
                foreach(var message1 in outputMessages)
                {
                    countiMessLen += message1.Length + 1;
                    outputList.Add(message1);
                    if(countiMessLen >maxLength)
                    {
                       return  string.Join(" ", outputList)+".....";
                    }

                }
            }
          
                return message;
            

        
            
           
        }

    }
}
