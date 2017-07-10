using Domain.Enums;
using Domain.Extensions;

namespace Domain
{
    public class Eagle : Bird
    {
        public override string DoSound()
        {
            return GlobalLocationEnum.BirdSound.Translate();
        }
    }
}