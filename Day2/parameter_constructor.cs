using System;
class cons
{
int percentage;
	public cons()
	{
	Console.WriteLine("Default constructor is invoked");
	}
	~cons()
	{
//destructor to remove the allocated memory by constructor
	}	
	public cons(int percent)
	{
	this.percentage = percent;
	Console.WriteLine(percent);
	Console.WriteLine("parameter constructor");
	}
public static void Main()
{
cons obj1 = new cons();
cons obj2 = new cons(87);
Console.WriteLine("Hello");
Console.WriteLine(obj2.percentage);
}
}