namespace AbdulRub
{
    public class MakeSquare
    {
        public int a;
        public void EnaterNValue()
        {
            Console.WriteLine("Please Enter (N) Value");
            string val = Console.ReadLine();
            a = int.Parse(val);
        }
        public void DisplayNSquare()
        {
            Console.WriteLine("N Square Value is "+ (a*a));
        }
    }
}
