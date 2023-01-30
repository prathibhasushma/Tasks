using System;
class parent 
{
	public void property()
	{
	Console.WriteLine("I own a property in ECR");
	}
}
class child : parent
{
	public void Health()
	{
	Console.WriteLine("I et good health from my parents");
	}
public static void Main()
{
	child cobj = new child();
	cobj.property();
	cobj.Health();
	parent pobj = new child();
	pobj.property();
	//pobj.Health();
}
}