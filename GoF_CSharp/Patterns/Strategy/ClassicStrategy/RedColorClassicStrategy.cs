using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.ClassicStrategy
{
    public class RedColorClassicStrategy : IColorClassicStrategy
    {
        public string Execute(Color color)
        {
            return color.Meaning = GlobalLocationEnum.RedMeaning.Translate();
        }
    }
}