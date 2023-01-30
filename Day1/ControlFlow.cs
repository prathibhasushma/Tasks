using System;
class ControlFlow
{
	public static void Main()
	{
	Console.WriteLine("Enter Your Age");
	int age = Convert.ToInt32(Console.ReadLine());
	if(age>=18)
	Console.WriteLine("You are eligible to attend the interview");
	else
	Console.WriteLine("Not Eligible");	
	}
}
