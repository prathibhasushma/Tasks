using System;
class switchcases
{
public static void Main()
{
Console.WriteLine("Mention your Medal");
string medal = console.ReadLine();
switch(medal)
{
case "gold" : Console.WriteLine("Olympic Gold Winner gets Lifetime free flight fare and BMW car and a pent house");
break;
case "silver" : Console.WriteLine("Olympic Silver Medal Winner gets a BMW car and a pent house ");
break;
case "Bronze" : Console.WriteLine("Bronze winner gets a pent house ");
break;
default: Console.WriteLine("Go get a medal");
break;
}
}
} 