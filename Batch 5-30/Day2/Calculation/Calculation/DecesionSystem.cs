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
        string[] name = new string[10000];

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
        public void CheckValueofInputChar()
        {
            Console.WriteLine("Enter A Char");
            string val = Console.ReadLine();
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(val);
            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                Console.WriteLine(ASCIIValues[i]);
            }
            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                Console.WriteLine(char.ConvertFromUtf32(ASCIIValues[i]));
            }
            //foreach (byte b in ASCIIValues)
            //{
            //    Console.WriteLine(b);
            //}
        }
        public void CheckitsCapital()
        {
            Console.WriteLine("Enter A Char");
            string val = Console.ReadLine();
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(val);
            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                string _realval = char.ConvertFromUtf32(ASCIIValues[i]);
                if ((ASCIIValues[i] >= 65) && (ASCIIValues[i] <= 90))
                {
                    Console.WriteLine(_realval + "is a Capital latter !");
                }
                else
                {
                    Console.WriteLine(_realval + "is a Small latter !");
                }
            }
        }
        public void ConvertToSmallLatter()
        {
            Console.WriteLine("Enter A Char");
            string val = Console.ReadLine();
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(val);
            Console.WriteLine("____________________________________________\n");
            //int i;
            for (int i=0; i < ASCIIValues.Length; i++)
            {
                int _temp = ASCIIValues[i] + 32;
                string _realval = char.ConvertFromUtf32(_temp);
                Console.Write(_realval);
            }
        }
        public void DisplayTable()
        {
            Console.WriteLine("Input a Number to Display Its Table");
            int table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(table * i);
            }
        }
    }
}
