using Domain;
using Domain.Enums;
using Domain.Extensions;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy.Interfaces;

namespace GoF_CSharp.Patterns.Strategy.SimpleStrategy.SpecificStrategies
{
    public class BlueColorStrategy : IColorStrategy
    {
        public string ColorName { get; set; } = GlobalLocationEnum.Blue.Translate();

        public string GetColorMeaning(Color color)
        {
            
            return color.Meaning = GlobalLocationEnum.BlueMeaning.Translate();

        }
    }
}