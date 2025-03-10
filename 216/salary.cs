using System;

class Employee
{
    public void CalculateGrossSalary(double basicSalary)
    {
        // Variables for allowances and Provident Fund
        double TA = 0, DA = 0, HRA = 0, PF = 0, grossSalary;

        // Checking the condition for basic salary range (35000 to 45000)
        if (basicSalary >= 35000 && basicSalary <= 45000)
        {
            // For salary between 35000 and 45000
            TA = basicSalary * 0.05;   // 5% of basic salary
            DA = basicSalary * 0.05;   // 5% of basic salary
            HRA = basicSalary * 0.15;  // 15% of basic salary
            PF = basicSalary * 0.085;  // 8.5% of basic salary
        }
        // For salary less than or equal to 35000
        else if (basicSalary <= 35000)
        {
            TA = basicSalary * 0.09;   // 9% of basic salary
            DA = basicSalary * 0.12;   // 12% of basic salary
            HRA = basicSalary * 0.20;  // 20% of basic salary
            PF = basicSalary * 0.085;  // 8.5% of basic salary
        }

        // Calculating gross salary
        grossSalary = basicSalary + TA + DA + HRA - PF;

        // Printing individual components
        Console.WriteLine("Basic Salary: " + basicSalary);
        Console.WriteLine("Travel Allowance (TA): " + TA);
        Console.WriteLine("Dearness Allowance (DA): " + DA);
        Console.WriteLine("House Rent Allowance (HRA): " + HRA);
        Console.WriteLine("Provident Fund (PF): " + PF);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("The Gross Salary of the employee is: " + grossSalary);
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Employee
        Employee employee = new Employee();

        // Input basic salary
        Console.Write("Enter the basic salary of the employee: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        // Call the CalculateGrossSalary method to calculate and print the gross salary
        employee.CalculateGrossSalary(basicSalary);
    }
}
