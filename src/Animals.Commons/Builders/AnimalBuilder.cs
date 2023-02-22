using Animals.Commons.ValueObjects;

namespace Animals.Commons.Builders;

public class AnimalBuilder
{
    private Specie _specie { get; set; }
    private string _name { get; set; }
    private string _color { get; set; }
    private int _age { get; set; }
    private Size _size { get; set; }
    private string _breed { get; set; }
    private string _hairType { get; set; }
    private int _wingSize { get; set; }
    private double _flightSpeed { get; set; }
    
    public AnimalBuilder Specie(Specie specie)
    {
        this._specie = specie;
        return this;
    }

    public AnimalBuilder Name(string name)
    {
        this._name = name;
        return this;
    }

    public AnimalBuilder Color(string color)
    {
        this._color = color;
        return this;
    }

    public AnimalBuilder Age(int age)
    {
        this._age = age;
        return this;
    }

    public AnimalBuilder Size(Size size)
    {
        this._size = size;
        return this;
    }

    public AnimalBuilder Breed(string breed)
    {
        this._breed = breed;
        return this;
    }

    public AnimalBuilder HairType(string hairType)
    {
        this._hairType = hairType;
        return this;
    }

    public AnimalBuilder WingSize(int wingSize)
    {
        this._wingSize = wingSize;
        return this;
    }

    public AnimalBuilder FlightSpeed(double flightSpeed)
    {
        this._flightSpeed = flightSpeed;
        return this;
    }

    public AbstractAnimalVO Build()
    {
        AbstractAnimalVO animal =  _specie switch
        {
            Animals.Commons.ValueObjects.Specie.DOG => new DogVO
            {
                Breed = _breed,
            },
            Animals.Commons.ValueObjects.Specie.CAT => new CatVO
            {
                HairType = _hairType,
            },
            Animals.Commons.ValueObjects.Specie.HORSE => new HorseVO(),
            Animals.Commons.ValueObjects.Specie.BIRD => new BirdVO
            {
                WingSize = _wingSize,
                FlightSpeed = _flightSpeed,
            },
            _ => throw new NotImplementedException(),
        };

        animal.Name = _name;
        animal.Color = _color;
        animal.Age = _age;
        animal.Size = _size;

        return animal;
    }
}
