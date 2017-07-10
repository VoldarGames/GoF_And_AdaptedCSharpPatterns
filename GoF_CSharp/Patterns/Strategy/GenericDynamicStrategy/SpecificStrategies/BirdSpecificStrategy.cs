using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.GenericDynamicStrategy.SpecificStrategies
{
    public class BirdSpecificStrategy : IGenericStrategy<Bird>
    {
        public string StrategyLabel { get; set; } = GlobalLocationEnum.Bird.Translate();

        public void Execute(Bird entity)
        {
            entity.Name = GlobalLocationEnum.FlyPhrase.Translate();
        }
    }
}