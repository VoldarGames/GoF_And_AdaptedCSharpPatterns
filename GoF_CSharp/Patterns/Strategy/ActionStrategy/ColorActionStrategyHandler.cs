using System;
using System.Collections.Generic;
using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.ActionStrategy
{
    public class ColorActionStrategyHandler
    {
        private static Dictionary<string, Func<Color,string>> ColorStrategies { get; } = new Dictionary<string, Func<Color,string>>()
        {
            {GlobalLocationEnum.Red.Translate(), color =>
                {
                    return color.Meaning = GlobalLocationEnum.RedMeaning.Translate();
                }
            },
            {GlobalLocationEnum.Green.Translate(), color =>
                {
                    return color.Meaning = GlobalLocationEnum.GreenMeaning.Translate();
                }
            },
            {GlobalLocationEnum.Blue.Translate(), color =>
            {
                return color.Meaning = GlobalLocationEnum.BlueMeaning.Translate();
            }},
        };

        public static string Handle(Color color)
        {
            if (string.IsNullOrEmpty(color?.Name) || !ColorStrategies.ContainsKey(color.Name)) return string.Empty;
            return ColorStrategies[color.Name].Invoke(color);
        }
    }
}