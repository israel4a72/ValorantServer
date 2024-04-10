using ValorantServer.Domain.Contexts.Settings.Entities;
using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Infra.Repositories.Settings
{
    public class GraphicsRepository
    {
        private IEnumerable<GraphicsSetting> GraphicsSettings { get; set; }
        public GraphicsRepository()
        {
            GraphicsSettings = [
                new GraphicsSetting(new Guid(), ETextureLevel.Low),
                new GraphicsSetting(new Guid(), ETextureLevel.Medium)
            ];
        }
        public async Task<GraphicsSetting> GetFromPlayerAsync(Guid playerId)
        {
            return GraphicsSettings.FirstOrDefault();
        }
        public async Task<IEnumerable<GraphicsSetting>> GetAllAsync()
        {
            return GraphicsSettings.ToList();
        }
        public async Task UpdateAsync(GraphicsSetting setting)
        {
            var oldSetting = await GetFromPlayerAsync(setting.PlayerId);

            if (oldSetting is GraphicsSetting)
                GraphicsSettings = GraphicsSettings.Select(gs => gs.PlayerId == setting.PlayerId ? setting : gs).ToList();
        }
    }
}