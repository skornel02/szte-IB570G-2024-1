using System.ComponentModel.DataAnnotations;

namespace hazi3.Entities;

public class CategoryEntity
{
    public long Id { get; set; }

    [Display(Name = "Kategória neve")]
    [Length(1, 30, ErrorMessage = "A kategória neve 1 és 30 karakter között kell lennie!")]
    public required string Name { get; set; }

    [Display(Name = "Rövid leírás")]
    [DataType(DataType.MultilineText)]
    public required string Description { get; set; }

    public List<PetEntity> Pets { get; set; } = null!;
}
