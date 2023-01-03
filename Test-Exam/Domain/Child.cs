using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Child
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; }
    [Required, Range(3, 6)]
    public int Age { get; }
    [Required]
    public string Gender { get; }
    public ICollection<Toy> Toys { get; set; }

    public Child(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}