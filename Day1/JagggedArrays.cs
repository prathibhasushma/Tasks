using System;
class jaggedarrays
{
public static void Main()
{
 string [][] patients = new string[3][];
 patients [0] = new string [3] {"Pat","Cat","Mat"};
 patients [1] = new string [2] {"Kan","Man"};
 patients [2] = new string [5] {"Cry","Fry","Try","Dry","Sky"};
 Console.WriteLine(patients.Length);
 for (int i = 0 ;i < patients.Length ; i++)
	{
	for (int j = 0 ; j < patients[i].Length;j++)
	Console.Write(patients[i][j] + "\t");
	Console.WriteLine();
	}
}
}

