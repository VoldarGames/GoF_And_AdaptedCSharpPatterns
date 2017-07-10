using Domain.Enums;
using Domain.Extensions;

namespace Domain
{
    public class Fox : Mamal
    {
        public override string DoSound()
        {
            return GlobalLocationEnum.MamalSound.Translate();
        }
    }
}