﻿using Sync.Tools;
using Sync.Tools.ConfigurationAttribute;

namespace OsuRTDataProvider
{
    public class DefaultLanguage : I18nProvider
    {
        public static LanguageElement LANG_OSU_NOT_FOUND = "[OsuRTDataProvider][ID:{0}]Not found osu!.exe process";
        public static LanguageElement LANG_OSU_FOUND = "[OsuRTDataProvider][ID:{0}]Found osu!.exe process";

        public static LanguageElement LANG_INIT_STATUS_FINDER_FAILED = "[OsuRTDataProvider][ID:{0}]Init StatusFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_STATUS_FINDER_SUCCESS = "[OsuRTDataProvider][ID:{0}]Init StatusFinder Success!";
        public static LanguageElement LANG_INIT_PLAY_FINDER_FAILED = "[OsuRTDataProvider][ID:{0}]Init PlayFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_PLAY_FINDER_SUCCESS = "[OsuRTDataProvider][ID:{0}]Init PlayFinder Success!";
        public static LanguageElement LANG_INIT_BEATMAP_FINDER_FAILED = "[OsuRTDataProvider][ID:{0}]Init BeatmapFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_BEATMAP_FINDER_SUCCESS = "[OsuRTDataProvider][ID:{0}]Init BeatmapFinder Success!";
        public static LanguageElement LANG_INIT_MODE_FINDER_FAILED = "[OsuRTDataProvider][ID:{0}]Init ModeFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_MODE_FINDER_SUCCESS = "[OsuRTDataProvider][ID:{0}]Init ModeFinder Success!";

        public static LanguageElement LANG_BEATMAP_NOT_FOUND = "Beatmap not found";

        public static GuiLanguageElement ListenInterval = "Listen interval(ms)";
        public static GuiLanguageElement EnableTourneyMode = "Tourney mode";
        public static GuiLanguageElement TeamSize = "Team size";
        public static GuiLanguageElement DebugMode = "Debug mode";
        public static GuiLanguageElement ForceOsuSongsDirectory = "Force OSU! songs directory";
        public static GuiLanguageElement GameMode = "Game Mode";
        public static GuiLanguageElement DisableProcessNotFoundInformation = "Disable OSU! process not found information";
        public static GuiLanguageElement EnableModsChangedAtListening = "Enable Mods Changed At Listening(Experimental)";
    }
}