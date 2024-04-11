using ValorantServer.Domain.Contexts.Settings.Enums;
using ValorantServer.Domain.Contexts.Settings.Extensions;

namespace ValorantServer.API.DTOs.Settings
{
    public class ReadVideoSettingDTO
    {
        public Guid PlayerId { get; set; }
        public string TextureLevelName { get; set; }

        public ReadVideoSettingDTO(Guid playerId, EQualityLevel textureLevel)
        {
            PlayerId = playerId;
            TextureLevelName = textureLevel.GetQualityLevelName();
        }
    }
}