using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Domain.Contexts.Settings.Extensions
{
    public static class TextureLevelExtension
    {
        public static string GetTextureLevelName(this ETextureLevel textureLevel)
        {
            return textureLevel switch
            {
                ETextureLevel.Low => "Low",
                ETextureLevel.Medium => "Medium",
                ETextureLevel.High => "High",
                ETextureLevel.Ultra => "Ultra",
                _ => "Undefined"
            };
        }
        public static ETextureLevel GetTextureLevelByName(this string textureLevelName)
        {
            return textureLevelName switch
            {
                "Low" => ETextureLevel.Low,
                "Medium" => ETextureLevel.Medium,
                "High" => ETextureLevel.High,
                "Ultra" => ETextureLevel.Ultra,
                _ => ETextureLevel.Undefined
            };
        }
    }
}