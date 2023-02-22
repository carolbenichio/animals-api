namespace Animals.Commons.ValueObjects;

public class BirdVO : AbstractAnimalVO
{
    public override Specie Specie => Specie.BIRD;
    public int WingSize { get; set; }
    public double FlightSpeed { get; set; }
}
