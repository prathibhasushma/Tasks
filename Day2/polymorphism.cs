using System;
class poly
{
	public void add(int num1,int num2)
	{
	Console.WriteLine(num1+num2);
	}
	public void add()
	{
	Console.WriteLine("Hello World");
	}
	public void add (double num1,int num2)
	{
	Console.WriteLine(num1+num2);
	}
public static void Main()
{
poly obj = new poly();
obj.add(10,10);
obj.add();
obj.add(10.2,10);
}
}
	