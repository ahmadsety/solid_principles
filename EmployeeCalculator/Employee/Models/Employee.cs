
namespace EmployeeCalculator;
public class Employee
{
    public double Salary { get; set; }
    public string Name { get; set; }
    public Employee Manager { get; set; }
    
    public double Calculate() {
        return Salary;
    }
    public void SetManager(Employee manager) {
        Manager = manager;
    }
} 