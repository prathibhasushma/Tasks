using System;
class array3
{
public static void Main()
{
int [,] mat = new int[2,3]{{1,2,3},{4,5,6}};
for (int i = 0;i<2;i++)
{
	for (int j= 0;j<3;j++)
	Console.Write(mat[i,j]+"\t");
	Console.WriteLine();
}
}
}