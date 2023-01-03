namespace Exercise_2._1;

public class Test
{
    public static void Main(string[] args)
    {
        Company company = new Company();

        Employee employee1 = new PartTimeEmployee("Rojus", 120, 42);
        Employee employee2 = new FullTimeEmployee("Ignas", 20000);
        
        company.HireNewEmployee(employee1);
        company.HireNewEmployee(employee2);
        
        Console.WriteLine(company.GetMonthlySalaryTotal());
    }
}