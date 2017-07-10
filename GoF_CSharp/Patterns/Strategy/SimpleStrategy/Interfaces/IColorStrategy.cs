using Domain;

namespace GoF_CSharp.Patterns.Strategy.SimpleStrategy.Interfaces
{
    public interface IColorStrategy
    {
        string ColorName { get; set; }
        string GetColorMeaning(Color color);
    }
}