using Core.Library.Enums;

namespace Core.Library.Attributes
{
    public interface IAttribute
    {
        int Modifier { get; }
        AttributeName Name { get; }
        int Value { get; }
    }
}