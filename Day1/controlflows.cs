using System;
class controlflow
{
	public static void Main()
	{
	Console.WriteLine("Enter your age");
	int age = Convert.ToInt32(Console.ReadLine());
	if (age < 18)	
	Console.WriteLine("Consult a pediatrician");
	else if (age>=18 && age <= 22)
	Console.WriteLine("Consult a adol specialist");
	else if ( age > 22 && age < 60 )
	Console.WriteLine("Consult a general physician");
	else
	Console.WriteLine("Consult geretrician");
	}
}