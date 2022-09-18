using Microsoft.AspNetCore.Mvc;
using EmployeeCalculator;

namespace EmployeeCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    private EmployeeFactory employeeFactory;
    public EmployeeController(EmployeeFactory factory)
    {
        employeeFactory = factory;
    }
    
    [HttpPost(Name = "CalculateSalary")]
    public double CalculateSalary([FromBody] SalaryDetails salaryDetails)
    {
        Employee employee = employeeFactory.Create(salaryDetails);
        employee.Salary = salaryDetails.Salary;
        employee.Name = salaryDetails.Name;
        return employee.Calculate();
    }
}
