using BizCap.Carol.Commons.ValueObjects;

namespace BizCap.Carol.Api.ValueObjects;

public class AnimalsListVO
{
    public Guid Id { get; set; }
    public IEnumerable<AbstractAnimalVO> Animals { get; set; }
}
