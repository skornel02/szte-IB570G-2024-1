using hazi2.Models;
using hazi2.Persistance;

namespace hazi2.Controllers;

public class PetController : IPetStore
{
    private readonly IPetStore _petStore;

    private event Action<List<PetEntity>>? OnPetsChangeEvent;

    public event Action<List<PetEntity>>? OnPetsChange
    {
        add
        {
            OnPetsChangeEvent += value;
            value?.Invoke(_petStore.Pets);
        }
        remove => OnPetsChangeEvent -= value;
    }

    public List<string> Categories { get; init; }

    public List<PetEntity> Pets => _petStore.Pets;

    public PetController(IPetStore petStore)
    {
        _petStore = petStore;

        Categories = _petStore.Pets.Select(_ => _.Category)
            .Distinct()
            .ToList();

        if (Categories.Count == 0)
        {
            Categories.Add("Kutya");
        }
    }

    public bool AddPet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        var result = _petStore.AddPet(pet);
        OnPetsChangeEvent?.Invoke(_petStore.Pets);

        return result;
    }

    public bool UpdatePet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        var result = _petStore.UpdatePet(pet);
        OnPetsChangeEvent?.Invoke(_petStore.Pets);

        return result;
    }

    public bool RemovePet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        var result = _petStore.RemovePet(pet);
        OnPetsChangeEvent?.Invoke(_petStore.Pets);

        return result;
    }
}
