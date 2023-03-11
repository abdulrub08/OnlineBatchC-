using AbdulRub;
using Calculation;
using CustomerTransaction;


//CustomerInfo customerInfo = new CustomerInfo();
//customerInfo._name = "Abdul";
//customerInfo._id = 1;
//customerInfo.age = 20;
//customerInfo.department = "IT";

Spouse _obj_person = new Spouse()
{
    Name = "XYZ",
    Age = 23,
    Salary = 2000
};
CustomerService customerService = new CustomerService();
bool _checkAdd = customerService.AddCustomerInfo();
_checkAdd = customerService.AddCustomerInfo(10);
_checkAdd = customerService.AddCustomerInfo(_obj_person);
if (_checkAdd)
{
   customerService.DisplayCustomerInfo();
}

//Person p1 = new Person("Wally",27);
//p1.DisplaySeries();
//Person p3 = new Person("Wally",27);
//Person p4 = new Person("Wally",27);
//Person p5 = new Person("Wally", 27);

//LoopExample loopExample = new LoopExample();
//Person p = new Person("Wally",27);
//Person p2 = new Person("Terri", 30);
//p2.Salary = 20;
//p2.Spouse = p2;
//p2.Salary = 30;
Console.Read();
//LoopExample.salary = 2000;
//
//LoopExample.DisplaySalary();
//Console.WriteLine();
//loopExample.DisplayStudentDetails("Test Data", 30);
//loopExample.i = 30;
//loopExample = null;
//loopExample = new LoopExample();
//loopExample.i = 20;
//loopExample.PrintSquareValue();
//loopExample.i = 10;
//loopExample.salary = (40 * 5000);
//loopExample.DisplaySalary();

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//DecesionSystem decesion = new DecesionSystem();
//decesion.DisplayTable();
//decesion.AcceptNumber();
//decesion.CheckItsEvenOrOdd();
//decesion.CheckSmallestNumber();
//MakeSquare obj = new MakeSquare();
//obj.EnaterNValue();
//obj.DisplayNSquare();
//Console.Read();

//InputTwoNumberFromUser();
//Add();
//DisplayTotalNumber();
//Console.Read();
//string firstval;
//string secondval;
//Int64 sum;

//ReturnType FunctiName()
//{//Start
//Statement Code
//}//End
//Example

//void InputTwoNumberFromUser()
//{    
//    Console.WriteLine("Please Enter A First Number");
//    firstval = Console.ReadLine();

//    Console.WriteLine("Please Enter A Second Number");
//    secondval = Console.ReadLine();
//}

//void Add()
//{
//    sum = Convert.ToInt64(firstval) + Convert.ToInt64(secondval);
//}

//void DisplayTotalNumber()
//{
//    Console.WriteLine(sum);
//}


//Avarage A+B+C/3

//AirthMatic Operator
//- + % * /

//a=97,b=98-------z=122
//A=65,B=66-------Z=90
//Difference 32 
//65+32=97
//97-32=65

//Study
//While loop
//Do While Loop

///
/// 
//Inhiretance
//Interface
//Method Overriding
//Constructor Overloading
//this Keyword
/// 
///




