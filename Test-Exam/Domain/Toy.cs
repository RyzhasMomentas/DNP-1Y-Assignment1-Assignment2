using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Toy
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(20)]
    public string Name { get; set; }
    public string Color { get; set; }
    public string Condition { get; set; }
    public bool IsFavorite { get; set; }
    public Child Owner { get; set; }

    public Toy(string name, string color, string condition, Child owner)
    {
        Name = name;
        Color = color;
        Condition = condition;
        Owner = owner;
    }
}