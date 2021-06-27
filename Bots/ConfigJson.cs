using Newtonsoft.Json;

namespace Towastie.Bots
{

    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string token { get; private set; }
        [JsonPropert("prefix")]
        public string Prefix { get; private set; }
    }
}