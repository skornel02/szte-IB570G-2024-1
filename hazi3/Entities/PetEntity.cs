namespace hazi3.Entities;

public class PetEntity
{
    public long Id { get; set; }

    public required string Name { get; set; }

    public required string Gender { get; set; }

    public required int Age { get; set; }

    public required decimal Weight { get; set; }

    public required string PhotoUrl { get; set; }

    public CategoryEntity? Category { get; set; }
}
