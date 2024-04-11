using ValorantServer.Domain.Contexts.Settings.Entities;
using ValorantServer.Domain.Contexts.Settings.Enums;
using ValorantServer.Domain.Contexts.Settings.ValueObjects;

namespace ValorantServer.Infra.Repositories.Settings
{
    public class VideoSettingRepository : BaseRepository<VideoSetting>
    {
        public VideoSettingRepository()
        {
            Entities = [
                new VideoSetting(
                    new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa8"), new Guid("6d373258-f84e-4420-a243-310c9fd685c3"),
                    new GeneralVideoSetting(
                        EResolutionLevel._720P, EDisplayMode.Windowed, "AMD Radeon RX 550", EAspectRatioMethod.Fill,
                        false, 60, false, 60, false, 60, false, 60
                    ),
                    new GraphicsQualitySetting(
                        EQualityLevel.Low, EQualityLevel.Low, EQualityLevel.Low, EQualityLevel.Low, false, false,
                        EAntialiasingLevel.None, EAnisotropicFiltering.None, false, false, false, false)),
                new VideoSetting(
                    new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa7"),
                    new Guid("afefbd0b-9003-42f9-abac-3df1a8133ec5"),
                    new GeneralVideoSetting(
                        EResolutionLevel._1080P, EDisplayMode.Fullscreen, "NVIDIA GeForce GTX 1050TI", EAspectRatioMethod.LetterBox,
                        false, 60, false, 60, false, 60, false, 60
                    ),
                    new GraphicsQualitySetting(
                        EQualityLevel.Low, EQualityLevel.Low, EQualityLevel.Medium, EQualityLevel.Low, false, false,
                        EAntialiasingLevel.None, EAnisotropicFiltering.None, false, false, false, false
                    )),
                new VideoSetting(
                    new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    new Guid("58500fc8-92ee-416b-83e0-c733faaced40"),
                    new GeneralVideoSetting(
                        EResolutionLevel._2160P, EDisplayMode.Fullscreen, "NVIDIA GeForce GTX 1660 Super", EAspectRatioMethod.Fill,
                        false, 60, false, 60, false, 60, false, 60
                    ),
                    new GraphicsQualitySetting(
                        EQualityLevel.Low, EQualityLevel.Ultra, EQualityLevel.Low, EQualityLevel.Low, false, false,
                        EAntialiasingLevel.None, EAnisotropicFiltering.None, false, false, false, false
                    ))
            ];
        }
        public async Task<VideoSetting?> GetFromPlayerAsync(Guid playerId)
        {
            await Task.CompletedTask;

            return Entities.FirstOrDefault(gs => gs.PlayerId == playerId);
        }
    }
}