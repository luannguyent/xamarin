using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp.Helpers
{
    public class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string GeneralSettings
        {
            get => AppSettings.GetValueOrDefault(nameof(GeneralSettings),"yes");

            set => AppSettings.AddOrUpdateValue(nameof(GeneralSettings), value);

        }
    }
}
