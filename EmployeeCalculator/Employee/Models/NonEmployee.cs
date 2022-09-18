using System;

namespace EmployeeCalculator;

public class NonEmployee: Employee
{
    public double Calculate()
    {
        Console.WriteLine("simulate Calculate");
        return 0;
    }

    public void SetManager(Employee manager)
    {
        Console.WriteLine("simulate manger set here");
    }
}