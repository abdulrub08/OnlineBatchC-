using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{   
    public class DecesionSystem
    {
        Int64 a, b;
        public void AcceptNumber()
        {
            Console.WriteLine("Please Enter A Number");
            a = Convert.ToInt64(Console.ReadLine());
        }
        public void CheckItsEvenOrOdd()
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("A is Even Number");
            }
            else
            {
                Console.WriteLine("A is Odd Number");
            }
        }
        public void AcceptTwoNumber()
        {
            Console.WriteLine("Please Enter A Number");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please Enter B Number");
            b = Convert.ToInt64(Console.ReadLine());
        }
        public void CheckGratestNumber()
        {
            if (a > b)
            {
                Console.WriteLine("A is Grater Then B");//TRUE
            }
            else
            {
                Console.WriteLine("B is Grater Then A");//False
            }
        }
        public void CheckSmallestNumber()
        {
            if (a < b)
            {
                Console.WriteLine("A is Smallest Then B");//TRUE
            }
            else
            {
                Console.WriteLine("B is Smallest Then A");//False
            }
        }
    }
}
