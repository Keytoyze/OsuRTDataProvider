﻿using Sync.Tools;

namespace MemoryReader
{
    internal class SettingIni : IConfigurable
    {
        public ConfigurationElement ListenInterval { set; get; }
        public ConfigurationElement NoFoundOsuHintInterval { set; get; }

        public void onConfigurationLoad()
        {
        }

        public void onConfigurationSave()
        {
        }
    }

    internal static class Setting
    {
        public static int ListenInterval = 33;//ms

        public static string SongsPath = "";//不保存

        private static SettingIni setting_output = new SettingIni();
        private static PluginConfiuration plugin_config = null;

        public static MemoryReader PluginInstance
        {
            set
            {
                plugin_config = new PluginConfiuration(value, setting_output);
            }
        }

        public static void SaveSetting()
        {
            setting_output.ListenInterval = ListenInterval.ToString();
            plugin_config.ForceSave();
        }

        public static void LoadSetting()
        {
            plugin_config.ForceLoad();
            if ((setting_output.NoFoundOsuHintInterval == null && setting_output.ListenInterval == null) ||
                (setting_output.NoFoundOsuHintInterval == "" && setting_output.ListenInterval == ""))
            {
                SaveSetting();
            }
            else
            {
                ListenInterval = int.Parse(setting_output.ListenInterval);
            }
        }
    }
}