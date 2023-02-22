using System.Text.Json.Serialization;

namespace Animals.Commons.ValueObjects;

public abstract class AbstractAnimalVO
{
    public abstract Specie Specie { get; }
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public Size Size { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Specie
{
    DOG, CAT, HORSE, BIRD,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Size
{
    SMALL, MEDIUM, BIG,
}
