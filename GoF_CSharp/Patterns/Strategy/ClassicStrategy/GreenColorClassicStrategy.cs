using Domain;
using Domain.Enums;
using Domain.Extensions;

namespace GoF_CSharp.Patterns.Strategy.ClassicStrategy
{
    public class GreenColorClassicStrategy : IColorClassicStrategy
    {

        public string Execute(Color color)
        {
            return color.Meaning = GlobalLocationEnum.GreenMeaning.Translate();
        }
    }
}