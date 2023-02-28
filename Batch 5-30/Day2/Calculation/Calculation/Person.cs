using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Person
    {
        private static string NewName;
        private string Name;
        private int Age;
        public int Salary;
        static Person()
        {
            NewName = "Test data";
            Console.WriteLine("Static Const Called");
        }
        public Person(string name,int age)
        {
            Console.WriteLine("Const Called");
            Name = name;
            Age = age;
        }
        public Person Spouse;
        public static void Displaydata()
        {
           
            NewName = "dfsdfsdfs";
            int age = 34534;
        }

        dynamic data = "dfsdfsd";
        //1,3,6,10,15,21
        public void DisplaySeries()//1,3
        {
            int sum = 0;
            int i = 1;
            while (i <= 30)
            {
                //sum = i + 2;
                //sum = sum + i;
                sum += i;
                i++;
                Console.WriteLine("Sum of The Series :- "+ sum);
            }
        }
    }
}
