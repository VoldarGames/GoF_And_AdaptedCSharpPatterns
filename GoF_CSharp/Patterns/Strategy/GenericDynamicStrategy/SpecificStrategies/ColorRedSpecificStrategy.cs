using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy.SpecificStrategies
{
    public class ColorRedSpecificStrategy : IGenericStrategy<Color>
    {
        public string StrategyLabel { get; set; } = GlobalLocationEnum.Red.Translate();

        public void Execute(Color entity)
        {
            entity.Meaning = GlobalLocationEnum.RedMeaning.Translate();
        }
    }
}