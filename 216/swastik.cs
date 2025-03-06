using System;

class swastik {
	
	static void swastika(int row, int col) 
	{
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) 
			{
				
				if (i < row / 2) 
				{
				
					if (j < col / 2) 
					{
						
						
						if (j == 0)
							Console.Write("*");
							
						
						else
							Console.Write(" "+ " ");
					}
					
					else if (j == col / 2)
						Console.Write(" *");
					
					else
					{
						
						if (i == 0)
							Console.Write(" *");
					}
				}
				else if (i == row / 2)
					Console.Write("* ");
				else
				{
					
				
					if (j == col / 2 || j == col - 1)
						Console.Write("* ");
					
					
					else if (i == row - 1) 
					{
						
						
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
	
	
	public static void Main ()
	{
		
	
		int row = 7, col = 7;
		
		
		swastika(row, col);
	}
}

