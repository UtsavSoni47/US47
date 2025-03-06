// C# implementation to print swastika pattern
using System;

class GFG {
	
	// function to print swastika
	static void swastika(int row, int col) 
	{
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) 
			{
				
				// checking if i < row/2
				if (i < row / 2) 
				{
					
					// checking if j < col/2
					if (j < col / 2) 
					{
						
						// print '*' if j = 0
						if (j == 0)
							Console.Write("*");
							
						// else print space
						else
							Console.Write(" "+ " ");
					}
					
					// check if j = col/2 
					else if (j == col / 2)
						Console.Write(" *");
					
					else
					{
						// if i=0 then first row 
						// will have '*'
						if (i == 0)
							Console.Write(" *");
					}
				}
				else if (i == row / 2)
					Console.Write("* ");
				else
				{
					
					// middle column and last column 
					// will have '*' after i > row/2
					if (j == col / 2 || j == col - 1)
						Console.Write("* ");
					
					// last row
					else if (i == row - 1) 
					{
						
						// last row will be have '*' if 
						// j <= col/2 or if it is last column
						if (j <= col / 2 || j == col - 1)
							Console.Write("* ");
						else
							Console.Write(" "+ " ");
					} 
					else
						Console.Write(" "+" ");
				}
			}
			
			Console.WriteLine();
		}
	} 
	
	// Driver code 
	public static void Main ()
	{
		
		// odd number of row and column
		// to get perfect swastika
		int row = 7, col = 7;
		
		// function calling
		swastika(row, col);
	}
}

// This code is contributed by vt_m.
