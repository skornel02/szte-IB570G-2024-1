using System.ComponentModel.DataAnnotations;

namespace hazi3.Entities;

public class PetEntity
{
    public long Id { get; set; }

    [Display(Name = "Kisállat neve")]
    [Required]
    [StringLength(60, ErrorMessage = "A kisállat neve 60 karakternél nem lehet hosszabb!")]
    public required string Name { get; set; }

    [Display(Name = "Nem-e (pl.: Hím, nőstény, támadó helikopter)")]
    [Required]
    [StringLength(30, ErrorMessage = "A nem nem lehet hosszabb 30 karakternél!")]
    public required string Gender { get; set; }

    [Display(Name = "Életkor")]
    [Range(0, 100, ErrorMessage = "Az életkor 0 és 100 között kell lennie!")]
    public required int Age { get; set; }

    [Display(Name = "Súly (kg)")]
    [Range(0, 1000, ErrorMessage = "A súly 0 és 1000 kg között kell lennie!")]
    public required decimal Weight { get; set; }

    [Display(Name = "Fénykép URL")]
    [Url(ErrorMessage = "A megadott URL nem érvényes!")]
    [DataType(DataType.ImageUrl)]
    public required string PhotoUrl { get; set; }

    [Display(Name = "Kategória")]
    public long? CategoryId { get; set; }

    public CategoryEntity? Category { get; set; }
}
