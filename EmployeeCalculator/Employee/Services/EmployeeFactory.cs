using EmployeeCalculator;

public class EmployeeFactory {
    public Employee Create (SalaryDetails salaryDetails)
    {
        switch (salaryDetails.Type)
        {
            case EmployeeType.Developer:
                return new Developer();
            case EmployeeType.Hr:
                return new HR();
            case EmployeeType.Manager:
                return new Manager();
            case EmployeeType.Sales:
                return new Sales();
            case EmployeeType.LeadDeveloper:
                return new LeadDeveloper();
            default:
                return new NonEmployee();
        }
    }
}