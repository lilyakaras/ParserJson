using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ParserJson
{
    class Root
    {
        [JsonPropertyName("section1")]
        public Section1 Section1 { get; set; }
    }
}
