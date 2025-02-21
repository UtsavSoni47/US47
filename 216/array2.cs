using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements you want to input:");
        int size = int.Parse(Console.ReadLine());

        int[] userValues = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter value for element {i + 1}:");
            userValues[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The values you entered are:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Element {i + 1}: {userValues[i]}");
        }
    }
}