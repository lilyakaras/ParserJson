using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ParserJson
{
    class Section1
    {
        [JsonPropertyName("value1")]
        public string Value1 { get; set; }

        [JsonPropertyName("subsection1")]
        public Subsection1 Subsection1 { get; set; }
    }
}
