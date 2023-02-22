namespace Animals.Commons.ValueObjects;

public class DogVO : AbstractAnimalVO
{
    public override Specie Specie => Specie.DOG;
    public string Breed { get; set; }
}
