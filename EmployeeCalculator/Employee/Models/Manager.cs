
using EmployeeCalculator;

public class Manager : Employee, IManager {
    public double Calculate(double bouns) {
        return Salary + bouns;
    }
}