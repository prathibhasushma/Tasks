using System;
class methods1
{
int n1,n2;
public void addition(int num1,int num2)
	{
	n1 = num1;
	n2 = num2;
	Console.WriteLine(n1+n2);
	}
public static void Main()
{
methods1 obj = new methods1();
Console.WriteLine("Enter the numebers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
obj.addition(num1,num2);
Console.WriteLine(obj.n1 + obj.n2);
}
}
 
	