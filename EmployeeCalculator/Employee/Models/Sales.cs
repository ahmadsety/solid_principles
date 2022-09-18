
using EmployeeCalculator;

public class Sales : Employee {
    public double Calculate(double target) {
        if (target >= 1000) {
            return Salary * 1.15;
        }
        return Salary;
    }
    
    public void SetManager(Manager manager) {
        Manager = manager;
    }
}