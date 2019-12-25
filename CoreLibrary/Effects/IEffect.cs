using Core.Library.Enums;

namespace Core.Library.Effects
{
    public interface IEffect
    {
        ApplicableProperty ConcerningProperty { get; set; }
        string Name { get; set; }
        int Value { get; set; }
    }
}