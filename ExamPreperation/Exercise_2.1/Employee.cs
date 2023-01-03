using System.Transactions;

namespace Exercise_2._1;

public abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double GetMonthlySalary();
}