using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy.SpecificStrategies
{
    public class ColorGreenSpecificStrategy : IGenericStrategy<Color>
    {
        public string StrategyLabel { get; set; } = GlobalLocationEnum.Green.Translate();

        public void Execute(Color entity)
        {
            entity.Meaning = GlobalLocationEnum.GreenMeaning.Translate();
        }
    }
}