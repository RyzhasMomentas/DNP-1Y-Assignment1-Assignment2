namespace Exercise1;

public class Person
{
    private String name;

    public Person(String name)
    {
        this.name = name;
    }
    

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {name}");
    }
}