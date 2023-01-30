using System;
class mother
{
	string name;
	int value;
	public mother(string name,int value)
	{
	this.name = name;
	this.value = value;
	}
public void display()
{
Console.WriteLine("the name of our property is {0} and the price is {1} "name,value);
}
class daughter:mother
{
	public daughter (string name,int value ) : base (name,val) //takes the values of name and val to the base class constructor as arguments
	{
	}
}
class implementcons
{
public static void Main()
{
Console.WriteLine("Enter the place");
string nam = Console.ReadLine();
Console.WriteLine("Enter the year");
int val = Convert.ToInt32(Console.ReadLine());
daughter obj = new daughter(nam,val);
obj.display(); 
}  
}
}