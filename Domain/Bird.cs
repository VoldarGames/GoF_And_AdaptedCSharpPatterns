using Domain.Enums;
using Domain.Extensions;

namespace Domain
{
    public abstract class Bird : Animal
    {
        public string Fly()
        {
            return GlobalLocationEnum.FlyPhrase.Translate();
        }
    }
}