using Animals.Commons.Builders;
using Animals.Commons.Types;
using Animals.Commons.ValueObjects;

namespace Animals.Commons.Factories;

public static class AnimalFactory
{
    public static AbstractAnimalVO CreateAnimal(Specie specie)
    {
        var animalBuilder = new AnimalBuilder();
        animalBuilder
            .Specie(specie)
            .Name(AnimalTypes.Names[Random.Shared.Next(AnimalTypes.Names.Length)])
            .Color(AnimalTypes.Colors[Random.Shared.Next(AnimalTypes.Colors.Length)])
            .Age(GetAge(specie))
            .Size(GetSize());

        switch (specie)
        {
            case Specie.DOG:
                animalBuilder.Breed(AnimalTypes.BreedTypes[Random.Shared.Next(AnimalTypes.BreedTypes.Length)]);
            break;
            case Specie.CAT:
                animalBuilder.HairType(AnimalTypes.HairTypes[Random.Shared.Next(AnimalTypes.HairTypes.Length)]);
            break;
            case Specie.BIRD:
                animalBuilder.WingSize(Random.Shared.Next(20, 120));
                animalBuilder.FlightSpeed(Random.Shared.Next(65, 169));
            break;
        }
        
        return animalBuilder.Build();
    }

    private static int GetAge(Specie specie) => specie switch
    {
        Specie.DOG => Random.Shared.Next(1, 13),
        Specie.CAT => Random.Shared.Next(1, 18),
        Specie.HORSE => Random.Shared.Next(1, 30),
        Specie.BIRD => Random.Shared.Next(1, 5),
        _ => throw new NotImplementedException(),
    };

    private static Size GetSize()
    {
        var values = Enum.GetValues(typeof(Size));
        return (Size)values.GetValue(Random.Shared.Next(values.Length))!;
    }
}
