using hazi3.Enums;
using System.ComponentModel.DataAnnotations;

namespace hazi3.Entities;

public class OwnerEntity
{
    public long Id { get; set; }

    [Display(Name = "Tulajdonos neve")]
    [Length(10, 30, ErrorMessage = "A Tulajdonos neve 10 és 30 karakter között kell lennie!")]
    public required string Name { get; set; }

    [Display(Name = "Telefonszám")]
    [RegularExpression("\\+36[0-9]{2}-[0-9]{3}-[0-9]{4}", ErrorMessage = "A helyes telefonszám mintája: +3620-123-4567")]
    public required string PhoneNumber { get; set; }

    [Display(Name = "Lakókörnyezet")]
    public required HomeType HomeType { get; set; }

    [Display(Name = "Tapasztalt állattartó")]
    public required bool ExperiencedKeeper { get; set; }

    public List<PetEntity> Pets { get; set; } = null!;
}
