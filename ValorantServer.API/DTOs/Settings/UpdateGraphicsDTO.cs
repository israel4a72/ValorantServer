using ValorantServer.Domain.Contexts.Settings.Enums;
using ValorantServer.Domain.Contexts.Settings.Extensions;

namespace ValorantServer.API.DTOs.Settings
{
    public class UpdateGraphicsDTO
    {
        public Guid PlayerId { get; set; }
        public string TextureLevelName { get; set; }

        public UpdateGraphicsDTO(Guid playerId, ETextureLevel textureLevel)
        {
            PlayerId = playerId;
            TextureLevelName = textureLevel.GetTextureLevelName();
        }
    }
}