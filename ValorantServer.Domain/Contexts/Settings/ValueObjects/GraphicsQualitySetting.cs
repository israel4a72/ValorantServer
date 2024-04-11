using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Domain.Contexts.Settings.ValueObjects
{
    public class GraphicsQualitySetting
    {
        public GraphicsQualitySetting(EQualityLevel materialQuality, EQualityLevel textureQuality, EQualityLevel detailQuality,
            EQualityLevel uIQuality, bool vignette, bool vSync, EAntialiasingLevel antiAliasing, EAnisotropicFiltering anisotropicFiltering,
            bool improveQuality, bool bloom, bool distortion, bool firstPersonShadow)
        {
            MaterialQuality = materialQuality;
            TextureQuality = textureQuality;
            DetailQuality = detailQuality;
            UIQuality = uIQuality;
            Vignette = vignette;
            VSync = vSync;
            AntiAliasing = antiAliasing;
            AnisotropicFiltering = anisotropicFiltering;
            ImproveQuality = improveQuality;
            Bloom = bloom;
            Distortion = distortion;
            FirstPersonShadow = firstPersonShadow;
        }

        public EQualityLevel MaterialQuality { get; private set; }
        public EQualityLevel TextureQuality { get; private set; }
        public EQualityLevel DetailQuality { get; private set; }
        public EQualityLevel UIQuality { get; private set; }
        public bool Vignette { get; private set; }
        public bool VSync { get; private set; }
        public EAntialiasingLevel AntiAliasing { get; private set; }
        public EAnisotropicFiltering AnisotropicFiltering { get; private set; }
        public bool ImproveQuality { get; private set; }
        public bool Bloom { get; private set; }
        public bool Distortion { get; private set; }
        public bool FirstPersonShadow { get; private set; }

        public void SetTextureQuality(EQualityLevel textureQuality) => TextureQuality = textureQuality;
        public void SetUIQuality(EQualityLevel uiQuality) => UIQuality = uiQuality;
        public void SetVignette(bool vignette) => Vignette = vignette;
        public void SetVSync(bool vSync) => VSync = vSync;
        public void SetAntiAliasing(EAntialiasingLevel antiAliasing) => AntiAliasing = antiAliasing;
    }
}