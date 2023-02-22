using Animals.Api.ValueObjects;
using Animals.Commons.Factories;
using Animals.Commons.ValueObjects;

namespace Animals.Api.Services;

public class AnimalService
{
    private List<AnimalsListVO> _animals = new();

    public List<AnimalsListVO> GetAllAnimals() => _animals;

    public AnimalsListVO GetAnimalById(Guid animalId) => _animals.SingleOrDefault(list => list.Id == animalId);

    public List<AnimalsListVO> CreateAnimals(List<Specie> types, int quantity)
    {
        var animals = new List<AbstractAnimalVO>();
        
        for (int i = 0; i < quantity; i++)
        {
            var specie = (Specie)types[Random.Shared.Next(types.Count)];
            animals.Add(AnimalFactory.CreateAnimal(specie));
        }

        _animals.Add(new AnimalsListVO
        {
            Id = Guid.NewGuid(),
            Animals = animals,
        });

        return _animals;
    }
}
