using AbdulRub;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MakeSquare obj = new MakeSquare();
obj.EnaterNValue();
obj.DisplayNSquare();
Console.Read();

InputTwoNumberFromUser();
Add();
DisplayTotalNumber();
Console.Read();
string firstval;
string secondval;
Int64 sum;

//ReturnType FunctiName()
//{//Start
//Statement Code
//}//End
//Example

void InputTwoNumberFromUser()
{    
    Console.WriteLine("Please Enter A First Number");
    firstval = Console.ReadLine();
    
    Console.WriteLine("Please Enter A Second Number");
    secondval = Console.ReadLine();
}

void Add()
{
    sum = Convert.ToInt64(firstval) + Convert.ToInt64(secondval);
}

void DisplayTotalNumber()
{
    Console.WriteLine(sum);
}


//Avarage A+B+C/3

//AirthMatic Operator
//- + % * /



