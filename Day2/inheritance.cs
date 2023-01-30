using System;
class parent
{
	public void property()
	{
	Console.WriteLine("I have a property in ECR");
	}
}
class child : parent 	
{
	public static void Main()
{
 child obj = new child();
 obj.property();
}
}
