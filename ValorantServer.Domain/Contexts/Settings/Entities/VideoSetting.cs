using ValorantServer.Domain.Contexts.Settings.ValueObjects;
using ValorantServer.Domain.Shared;

namespace ValorantServer.Domain.Contexts.Settings.Entities
{
    public class VideoSetting : BaseEntity
    {
        public VideoSetting(Guid id, Guid playerId, GeneralVideoSetting generalVideoSetting, GraphicsQualitySetting graphicsQualitySetting) : base(id)
        {
            PlayerId = playerId;
            GeneralVideoSetting = generalVideoSetting;
            GraphicsQualitySetting = graphicsQualitySetting;
        }
        public Guid PlayerId { get; private set; }

        public GeneralVideoSetting GeneralVideoSetting { get; private set; }

        public GraphicsQualitySetting GraphicsQualitySetting { get; private set; }

        public void SetGeneralVideoSettings(GeneralVideoSetting generalVideoSetting)
        {
            GeneralVideoSetting = generalVideoSetting;
        }
        public void SetGraphicsQualitySettings(GraphicsQualitySetting graphicsQualitySetting)
        {
            GraphicsQualitySetting = graphicsQualitySetting;
        }
    }
}