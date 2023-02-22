using Animals.Commons.ValueObjects;

namespace Animals.Api.ValueObjects;

public class AnimalsListVO
{
    public Guid Id { get; set; }
    public IEnumerable<AbstractAnimalVO> Animals { get; set; }
}
