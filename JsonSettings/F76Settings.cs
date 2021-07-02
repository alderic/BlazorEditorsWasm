using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorEditorsWasm.JsonSettings
{
    public class F76Settings
    {
        internal readonly string f76Ini = "Fallout76.ini";
        internal readonly string f76CustomIni = "Fallout76Custom.ini";
        internal readonly string f76PrefsIni = "Fallout76Prefs.ini";

        [JsonIgnore]
        public string ExpandedIniFilesDir { get; set; }
        public string LauncherPath { get; set; }
        public bool Log { get; set; }
        public List<string> Strings { get; set; }
      ///  public List<ConfigFix> ConfigFixes { get; set; }
        public string ModsFolder { get; set; }
        public List<string> NwFiles { get; set; }
        public string IniFilesDir { get; set; }
        public string GamePath { get; set; }
        public List<string> DefaultGameLocations { get; set; }
        public string DefaultInstallPath { get; set; }
        public string ModsPath { get; set; }
    }
}