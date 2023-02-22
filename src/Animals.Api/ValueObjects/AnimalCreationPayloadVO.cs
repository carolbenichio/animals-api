using Animals.Commons.ValueObjects;

namespace Animals.Api.ValueObjects;

public class AnimalCreationPayloadVO
{
    public List<Specie> Types { get; set; } 
    public int Quantity { get; set; }
}
