using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Domain.Contexts.Settings.Extensions
{
    public static class ResolutionLevelExtension
    {
        public static string GetResolutionLevelName(this EResolutionLevel ResolutionLevel)
        {
            return ResolutionLevel switch
            {
                EResolutionLevel._720P => "Low",
                EResolutionLevel._900P => "Medium",
                EResolutionLevel._1080P => "High",
                EResolutionLevel._2160P => "Ultra",
                _ => "Undefined"
            };
        }
        public static EResolutionLevel GetResolutionLevelByName(this string ResolutionLevelName)
        {
            return ResolutionLevelName switch
            {
                "Low" => EResolutionLevel._720P,
                "Medium" => EResolutionLevel._900P,
                "High" => EResolutionLevel._1080P,
                "Ultra" => EResolutionLevel._2160P,
                _ => EResolutionLevel.Undefined
            };
        }
    }
}