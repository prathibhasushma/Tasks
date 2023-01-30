using System;
class methods2
{
int num1,num2;//Global variable
	public int sum(int num1,int num2)
	{
	int result;
	this.num1 = num1;//this is used to represent the assignment of variable to the globally declared variable in order to avoid confusion
	this.num2 = num2; 
	result = num1+num2;//takes the globally assigned parameters
	return result;
	}
	public int avg(int summation)
	{
	int average;
	average = summation/2;
	return average;
	}
public static void Main()
{
methods2 obj = new methods2();
int s = obj.sum(20,80);
int a = obj.avg(s);
Console.WriteLine("The average value is {0}",a);
Console.WriteLine("The sum is {0}",s);
}
}


