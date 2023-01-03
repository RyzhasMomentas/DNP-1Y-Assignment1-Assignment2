using Exercise_3.calculator;

namespace Exercise_3;

public class Test
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int sum = calculator.Add(2, 5);
        Console.WriteLine(sum);
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        Console.WriteLine(calculator.Add(numbers));
    }
}