using System.Collections.Generic;
using Domain;
using Domain.Enums;
using Domain.Extensions;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy.Interfaces;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy.SpecificStrategies;


namespace GoF_CSharp.Patterns.Strategy.SimpleStrategy
{
    public static class ColorStrategyHandler
    {
        private static Dictionary<string,IColorStrategy> ColorStrategies { get; }  = new Dictionary<string, IColorStrategy>()
        {
            {GlobalLocationEnum.Red.Translate(),new RedColorStrategy()},
            {GlobalLocationEnum.Green.Translate(),new GreenColorStrategy()},
            {GlobalLocationEnum.Blue.Translate(),new BlueColorStrategy()},
        };

        public static string Handle(Color color)
        {
            if (string.IsNullOrEmpty(color?.Name) || !ColorStrategies.ContainsKey(color.Name)) return string.Empty;
            return ColorStrategies[color.Name].GetColorMeaning(color);
        }
    }
}