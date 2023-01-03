namespace Exercise_2._1;

public class PartTimeEmployee : Employee
{
    public double HourlyWage;
    public int HoursPerMonth;

    public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
    {
        HourlyWage = hourlyWage;
        HoursPerMonth = hoursPerMonth;
    }

    public override double GetMonthlySalary()
    {
        return HourlyWage * HoursPerMonth;
    }
}