using System;

class swastikPattern
{
    static void swastik(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (i < row / 2)
                {
                    if (j < col / 2)
                    {
                        if (j == 0)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    else if (j == col / 2)
                        Console.Write("* ");
                    else
                    {
                        
                        if (i == 0)
                            Console.Write("* ");
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
                            Console.Write("  ");
                    }
                    else
                        Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        Console.Write("Enter an odd number of rows: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter an odd number of columns: ");
        int col = Convert.ToInt32(Console.ReadLine());

        if (row % 2 == 0 || col % 2 == 0)
        {
            Console.WriteLine("Please enter only odd numbers for rows and columns.");
            return;
        }

        swastik(row, col);
    }
}
