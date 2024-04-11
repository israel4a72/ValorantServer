namespace ValorantServer.API.DTOs.Settings
{
    public class UpdateVideoSettingDTO
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public string TextureQualityName { get; set; }

        public UpdateVideoSettingDTO(Guid id, Guid playerId, string textureQualityName)
        {
            Id = id;
            PlayerId = playerId;
            TextureQualityName = textureQualityName;
        }
    }
}