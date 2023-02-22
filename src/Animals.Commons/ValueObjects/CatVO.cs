namespace Animals.Commons.ValueObjects;

public class CatVO : AbstractAnimalVO
{
    public override Specie Specie => Specie.CAT;
    public string HairType { get; set; }
}
