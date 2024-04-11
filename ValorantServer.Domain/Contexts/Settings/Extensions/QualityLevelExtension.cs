using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Domain.Contexts.Settings.Extensions
{
    public static class TextureLevelExtension
    {
        public static string GetQualityLevelName(this EQualityLevel textureLevel)
        {
            return textureLevel switch
            {
                EQualityLevel.Low => "Low",
                EQualityLevel.Medium => "Medium",
                EQualityLevel.High => "High",
                EQualityLevel.Ultra => "Ultra",
                _ => "Undefined"
            };
        }
        public static EQualityLevel GetQualityLevelByName(this string textureLevelName)
        {
            return textureLevelName switch
            {
                "Low" => EQualityLevel.Low,
                "Medium" => EQualityLevel.Medium,
                "High" => EQualityLevel.High,
                "Ultra" => EQualityLevel.Ultra,
                _ => EQualityLevel.Undefined
            };
        }
    }
}