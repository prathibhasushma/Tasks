//constructor is used to initialize the data members inside a class and no return type
using System;
class cons
{
	int percentage;
	cons()//default constructor
	{	
	Console.WriteLine("Constructor invoked");
	percentage = 96;
	}
public static void Main()
{
cons obj = new cons();
Console.WriteLine("the percentage is"+obj.percentage);
}
}

	
