using Domain;
using Domain.Enums;
using Domain.Extensions;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy.Interfaces;

namespace GoF_CSharp.Patterns.Strategy.SimpleStrategy.SpecificStrategies
{
    public class GreenColorStrategy : IColorStrategy
    {
        public string ColorName { get; set; } = GlobalLocationEnum.Green.Translate();

        public string GetColorMeaning(Color color)
        {
            return color.Meaning = GlobalLocationEnum.GreenMeaning.Translate();
        }

    }
}