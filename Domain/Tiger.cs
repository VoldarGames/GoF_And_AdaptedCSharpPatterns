using Domain.Enums;
using Domain.Extensions;

namespace Domain
{
    public class Tiger : Mamal
    {
        public override string DoSound()
        {
            return GlobalLocationEnum.MamalSound.Translate();
        }
    }
}