using System;
class method2.1
{
int num1,num2;
	Public int sum (int num1,int num2)
	{
	this.num1 = num1;
	this.num2 = num2;
	int sum = num1 + num2;
	return sum;
	}
	public int avg (method2.1 m)
	{
	int average = m.sum(num1,num2);
	return average/2;
	}
public static void Main()
{
 method2.1 obj = new method2.1();
 int s = obj.sum(20,80);
 int a = obj.avg(obj)
 Console.WriteLine("The sum is {0}",s); 
 Console.WriteLine("The avg is {0}",a);
}
}
 	