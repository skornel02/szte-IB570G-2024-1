using hazi2.Models;

namespace hazi2.Persistance;

public class PetMemoryStore : IPetStore
{

    private readonly List<PetEntity> _pets = [];

    public List<PetEntity> Pets { get => _pets; }

    public bool AddPet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        _pets.Add(pet);

        return true;
    }

    public bool UpdatePet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        var index = _pets.FindIndex(p => p.Id == pet.Id);
        if (index == -1)
        {
            return false;
        }

        _pets[index] = pet;

        return true;
    }

    public bool RemovePet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        var index = _pets.FindIndex(p => p.Id == pet.Id);
        if (index == -1)
        {
            return false;
        }

        _pets.RemoveAt(index);

        return true;
    }
}
