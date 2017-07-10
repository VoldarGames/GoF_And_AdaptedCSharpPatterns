using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using GoF_CSharp.Patterns.Strategy.SimpleStrategy.Interfaces;

namespace GoF_CSharp.Patterns.Strategy.DynamicStrategy
{
    public static class ColorDynamicStrategyHandler
    {
        private static Dictionary<string,IColorStrategy> ColorStrategies { get; }  = new Dictionary<string, IColorStrategy>();

        public static string Handle(Color color)
        {
            if (!ColorStrategies.Any()) PopulateColorStrategies();
            if (string.IsNullOrEmpty(color?.Name) || !ColorStrategies.ContainsKey(color.Name)) return string.Empty;
            return ColorStrategies[color.Name].GetColorMeaning(color);
        }

        private static void PopulateColorStrategies()
        {
            var assembly = typeof(ColorDynamicStrategyHandler).Assembly;
            var strategies = assembly.DefinedTypes.Where(info => info.IsClass && typeof(IColorStrategy).IsAssignableFrom(info));
            foreach (var strategy in strategies)
            {
                var strategyInstance = (IColorStrategy)Activator.CreateInstance(strategy);
                ColorStrategies.Add(strategyInstance.ColorName, strategyInstance);
            }

        }
    }
}