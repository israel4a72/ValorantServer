using ValorantServer.Domain.Contexts.Settings.Enums;
using ValorantServer.Domain.Shared;

namespace ValorantServer.Domain.Contexts.Settings.Entities
{
    public class GraphicsSetting : BaseEntity
    {
        public GraphicsSetting(Guid playerId, ETextureLevel textureLevel)
        {
            PlayerId = playerId;
            TextureLevel = textureLevel;
        }
        public Guid PlayerId { get; set; }
        public ETextureLevel TextureLevel { get; set; }

        public EResolutionLevel ResolutionLevel { get; set; }
    }
}