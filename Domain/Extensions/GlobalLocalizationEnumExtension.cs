using System;
using Domain.Enums;
using Domain.Resources;

namespace Domain.Extensions
{
    public static class GlobalLocalizationEnumExtension
    {
        public static string Translate(this GlobalLocationEnum globalLocationEnum)
        {
            var globalLocationEnumName = Enum.GetName(typeof(GlobalLocationEnum), globalLocationEnum);
            return string.IsNullOrEmpty(globalLocationEnumName) ? string.Empty : GlobalLocation.ResourceManager.GetString(globalLocationEnumName);
        }
    }
}
