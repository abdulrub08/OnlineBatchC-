using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheitanceExample
{
    internal class Alpha
    {
        public Alpha()
        {
            Console.WriteLine("Constructor of Alpha");
        }
        int x, y;
        public virtual void M1()
        {
            Console.WriteLine("From M1");
        }
        public virtual void M2(string name, int count)
        {
            for (int i = 0; i< count; i++)
			{
                Console.WriteLine("From M2 :- " +name);
            }
        }
    }
    public abstract class AlphaAbstract
    {
        //public abstract void A3();
        public abstract void abstract_method();
        public void A1()
        {
            Console.WriteLine("From M1");
        }
        public void A2(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("From M2 :- " + name);
            }
        }
    }
}
