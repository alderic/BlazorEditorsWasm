namespace BlazorEditorsWasm.JsonSettings
{
    public class ConfigFix
    {
        public string Name { get; set; }
       // public List<ConfigFileFix> Files { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsRaw { get; internal set; }
    }
}