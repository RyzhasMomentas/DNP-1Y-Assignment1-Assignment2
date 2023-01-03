namespace Exercise_2._1;

public class Company
{
    private List<Employee> Employees=new List<Employee>();

    public double GetMonthlySalaryTotal()
    {
        double sum = 0;
        foreach (Employee employee in Employees)
        {
            sum = sum + employee.GetMonthlySalary();
        }

        return sum;
    }

    public void HireNewEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}