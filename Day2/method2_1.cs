using System;
class method2_1
{
int num1,num2;
	public int sum (int num1,int num2)
	{
	this.num1 = num1;
	this.num2 = num2;
	int sum = num1 + num2;
	return sum;
	}
	public int avg (method2_1 m)
	{
	int average = m.sum(num1,num2);
	return average/2;
	}
public static void Main()
{
 method2_1 obj = new method2_1();
 int s = obj.sum(20,80);
 int a = obj.avg(obj);
 Console.WriteLine("The sum is {0}",s); 
 Console.WriteLine("The avg is {0}",a);
}
}
 	