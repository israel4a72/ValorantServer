using ValorantServer.Domain.Contexts.Settings.Entities;
using ValorantServer.Domain.Contexts.Settings.Extensions;

namespace ValorantServer.API.DTOs.Settings.Extensions
{
    public static class GraphicsExtensions
    {
        public static GraphicsSetting MapToGraphicsSetting(this UpdateGraphicsDTO updateGraphicsDTO)
        {
            return new GraphicsSetting(updateGraphicsDTO.PlayerId, updateGraphicsDTO.TextureLevelName.GetTextureLevelByName());
        }
        public static ReadGraphicsDTO MapToReadGraphicsDTO(this GraphicsSetting graphicsSetting)
        {
            return new ReadGraphicsDTO(graphicsSetting.PlayerId, graphicsSetting.TextureLevel);
        }
    }
}