using Domain.Enums;
using Domain.Extensions;

namespace Domain
{
    public abstract class Mamal : Animal
    {
        public string Run()
        {
            return GlobalLocationEnum.RunPhrase.Translate();
        }
    }
}