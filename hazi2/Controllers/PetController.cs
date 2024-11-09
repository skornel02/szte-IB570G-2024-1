using hazi2.Models;

namespace hazi2.Controllers;

public class PetController
{
    private static readonly Lazy<PetController> _instance = new(() => new PetController());

    public static PetController Instance => _instance.Value;

    private event Action<List<PetEntity>>? OnPetsChangeEvent;

    public event Action<List<PetEntity>>? OnPetsChange
    {
        add {
            OnPetsChangeEvent += value;
            value?.Invoke(_pets);
        }
        remove => OnPetsChangeEvent -= value;
    }

    private readonly List<PetEntity> _pets = [];

    public List<PetEntity> Pets { get => _pets; }

    public List<string> Categories { get; init; } = ["Kutya"];

    private PetController()
    { }

    public bool AddPet(PetEntity pet)
    {
        if (pet == null)
        {
            return false;
        }

        _pets.Add(pet);
        OnPetsChangeEvent?.Invoke(_pets);

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
        OnPetsChangeEvent?.Invoke(_pets);

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
        OnPetsChangeEvent?.Invoke(_pets);

        return true;
    }
}
