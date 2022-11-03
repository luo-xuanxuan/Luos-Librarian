using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Luos_Librarian
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
