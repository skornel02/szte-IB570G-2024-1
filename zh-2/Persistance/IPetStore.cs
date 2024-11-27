using hazi2.Models;

namespace hazi2.Persistance;

public interface IPetStore
{
    public List<PetEntity> Pets { get; }

    public bool AddPet(PetEntity pet);

    public bool UpdatePet(PetEntity pet);

    public bool RemovePet(PetEntity pet);
}
