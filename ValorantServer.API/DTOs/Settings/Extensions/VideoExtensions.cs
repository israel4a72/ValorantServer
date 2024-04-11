using ValorantServer.Domain.Contexts.Settings.Entities;
using ValorantServer.Domain.Contexts.Settings.Extensions;

namespace ValorantServer.API.DTOs.Settings.Extensions
{
    public static class VideoExtensions
    {
        public static VideoSetting MapToVideoSetting(this UpdateVideoSettingDTO updateVideoSettingDTO, VideoSetting videoSettingToUpdate)
        {
            videoSettingToUpdate.GraphicsQualitySetting.SetTextureQuality(updateVideoSettingDTO.TextureQualityName.GetQualityLevelByName());

            return videoSettingToUpdate;
        }
        public static ReadVideoSettingDTO MapToReadVideoSettingDTO(this VideoSetting VideoSetting)
        {
            return new ReadVideoSettingDTO(VideoSetting.PlayerId, VideoSetting.GraphicsQualitySetting.TextureQuality);
        }
    }
}