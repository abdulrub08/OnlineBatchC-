using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class LoopExample
    {
        public void PrintSquareValue()
        {
            //1 ,4,9,16,25......
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i*i);
                i++;
            }
        }
        public void PrintAllSmallLater()
        {
            Console.WriteLine("\n\n\n");
            int i = 97;
            while (i <= 122)
            {
                string temp = char.ConvertFromUtf32(i);
                Console.Write(temp + " ");
                i++;
            }
            Console.WriteLine("\n\n\n");
        }
        //1----20
       // 1,2 3,---20
       //1+2+3+5
       //step 1-20 
         //  i
       //Q1:- Display Hello 40 Time
       //Q2:- 1,2,3---40 Print
       //Q3:- 2,4,6,8,10---50 Even No
       //Q4:- 1,3,5,7,9---50 Odd No
    }
}
