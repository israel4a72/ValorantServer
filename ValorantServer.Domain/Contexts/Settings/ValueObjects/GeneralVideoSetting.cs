using ValorantServer.Domain.Contexts.Settings.Enums;

namespace ValorantServer.Domain.Contexts.Settings.ValueObjects
{
    public class GeneralVideoSetting
    {
        public EResolutionLevel ResolutionLevel { get; private set; }
        public EDisplayMode DisplayMode { get; private set; }
        public string DisplayAdapter { get; private set; }
        public EAspectRatioMethod AspectRatioMethod { get; private set; }

        public bool LimitFPSOnBattery { get; private set; }
        public short MaxFPSOnBattery { get; private set; }
        public bool LimitFPSOnMenu { get; private set; }
        public short MaxFPSOnMenu { get; private set; }
        public bool LimitFPSInBackGround { get; private set; }
        public short MaxFPSInBackGround { get; private set; }
        public bool LimitFPSAlways { get; private set; }
        public short MaxFPSAlways { get; private set; }

        public GeneralVideoSetting(EResolutionLevel resolutionLevel, EDisplayMode displayMode, string displayAdapter,
            EAspectRatioMethod aspectRatioMethod, bool limitFPSOnBattery, short maxFPSOnBattery, bool limitFPSOnMenu,
            short maxFPSOnMenu, bool limitFPSInBackGround, short maxFPSInBackGround, bool limitFPSAlways, short maxFPSAlways)
        {
            ResolutionLevel = resolutionLevel;
            DisplayMode = displayMode;
            DisplayAdapter = displayAdapter;
            AspectRatioMethod = aspectRatioMethod;
            LimitFPSOnBattery = limitFPSOnBattery;
            MaxFPSOnBattery = maxFPSOnBattery;
            LimitFPSOnMenu = limitFPSOnMenu;
            MaxFPSOnMenu = maxFPSOnMenu;
            LimitFPSInBackGround = limitFPSInBackGround;
            MaxFPSInBackGround = maxFPSInBackGround;
            LimitFPSAlways = limitFPSAlways;
            MaxFPSAlways = maxFPSAlways;
        }
    }
}