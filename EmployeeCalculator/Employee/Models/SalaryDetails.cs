using EmployeeCalculator;

public class SalaryDetails
{
    public double Salary { get; set; }
    public string Name { get; set; }
    public EmployeeType Type { get; set; }
    public Employee? manager { get; set; }
    public double? Bonus { get; set; }

}