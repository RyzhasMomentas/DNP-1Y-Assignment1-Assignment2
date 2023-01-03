namespace Exercise_3.calculator;

public class Calculator
{
    
    
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Add(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        return sum;
    }
}