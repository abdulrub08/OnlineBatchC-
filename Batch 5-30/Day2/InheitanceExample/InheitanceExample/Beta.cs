using System;
namespace InheitanceExample
{
    internal class Beta:AlphaAbstract,IGama, IGama1,IGama2,IGama8,IGama3
    {
        int count;
        public Beta()
        {
            Console.WriteLine("Constructor of Beta Blank");
        }
        public Beta(int count)
        {
            Console.WriteLine("Constructor of Beta Integer :- " + this.count);
            this.count = count;
            Console.WriteLine("Constructor of Beta Integer :- " + count);
            this.count++;
            Console.WriteLine("Constructor of Beta Integer :- " + count);
            Console.WriteLine("Constructor of Beta Integer :- " + this.count);
        }
        public Beta(string count)
        {
            Console.WriteLine("Constructor of Beta string");
        }
        public Beta(string count,int data)
        {
            Console.WriteLine("Constructor of Beta string + Integer");
        }
        public void B3()
        {
            Console.WriteLine("From B3");
        }
        public override void abstract_method()
        {
            Console.WriteLine("Abstract method is called");
        }
        public void display(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void G1()
        {
            throw new NotImplementedException();
        }

        public void G2(string name, int count)
        {
            throw new NotImplementedException();
        }

        public void M1()
        {
            throw new NotImplementedException();
        }

    }
}
