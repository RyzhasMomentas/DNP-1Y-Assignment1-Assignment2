namespace Exercise_2;

public class Calculator
{
    public static void Main(string[] args)
    {
        int x = 10;
        int y = 3;

        PrintEven(x);
        PrintUneven(x);
        PrintDivisors(x, y);
    }

    public static void PrintEven(int x)
    {
        for (int i = 0; i < x; i++)
        {
            if(i%2==0)
                Console.WriteLine(i);
        }
    }

    public static void PrintUneven(int x)
    {
        for (int i = 0; i < x; i++)
        {
            if(i%2!=0)
                Console.WriteLine(i);
        }
    }

    public static void PrintDivisors(int x, int y)
    {
        for (int i = 0; i < x; i++)
        {
            if(i%y==0 && i!=0)
                Console.WriteLine(i);
        }
    }
}