using System;
namespace array
{
	class program
	{
		static void Main() 
		{
			int [] []jag=new int[3] [];
			jag[0]=new int [3] {1,2,3};
			jag[1]=new int [4] {4,5,6,7};
			jag[2]=new int [2] {8,9};
			for (int i=0;i<jag.Length;i++)
			{
				for(int j=0;j<jag[i].Length;j++)
				{
					Console.Write(jag[i][j]+"");
				}
				Console.WriteLine();
			}
		}
	}
}
		