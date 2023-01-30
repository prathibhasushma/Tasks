using System;
class Method 
{
	public void display()
	{
	Console.WriteLine(" This is my First Method ");
	}
	public void show()
	{
	Console.WriteLine("Show Time");
	}
	int num1; 
public static void Main()
{
Method obj = new Method();
obj.display();
obj.num1 = 100;
Method obj1 = new Method();
obj1.display();
obj1.display();
obj1.show();
obj.show();
Console.WriteLine(obj.num1);
Console.WriteLine(obj1.num1);
}
}
