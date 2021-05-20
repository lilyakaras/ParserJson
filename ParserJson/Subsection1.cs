using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ParserJson
{
    class Subsection1
    {
        [JsonPropertyName("value2")]
        public string Value2 { get; set; }
    }
}
