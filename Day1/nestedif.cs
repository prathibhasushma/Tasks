using System;
class nestedif
{
public static void Main()
{
Console.WriteLine("Enter Your Gender");
string gender = Console.ReadLine();
Console.WriteLine("Enter Your Age");
int age = Convert.ToInt32(Console.ReadLine());
if ( gender == "male")
{
if (age > 22)
Console.WriteLine("Consult a General Physician ");
}
else if ( gender == "Female")
{
if (age > 22)
Console.WriteLine("Consult a gynaecologist");
}
else
Console.WriteLine("Consult AndroGynae");
}
}