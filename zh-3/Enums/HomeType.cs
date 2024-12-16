using System.ComponentModel.DataAnnotations;

namespace hazi3.Enums;

public enum HomeType
{
    [Display(Name = "Belváros")]
    City,
    [Display(Name = "Kertváros")]
    Suburbs,
    [Display(Name = "Tanya")]
    CountrySide,
}
