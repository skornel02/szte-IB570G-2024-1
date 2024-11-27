namespace hazi2.Models;

public class PetEntity
{
    public long Id { get; set; }

    public required string Name { get; set; }

    public required string Gender { get; set; }

    public required string OwnerName { get; set; }

    public int Age { get; set; }

    public decimal Weight { get; set; }

    public required string Category { get; set; }

    public string ExportString
        => $"{Id};{Name};{OwnerName};{Age};{Weight};{Category}";
}
