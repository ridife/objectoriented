using Newtonsoft.Json;

namespace ZodiacRestAPI
{
    public class ZodiacResult
    {
        [JsonProperty(PropertyName = "sunsign")]
        public string SunSign { get; set; }

        [JsonProperty(PropertyName = "horoscope")]
        public string Quotes { get; set; }

        [JsonProperty(PropertyName = "meta")]
        public Meta Content { get; set; }
    }

    public class Meta
    {
        public string Mood { get; set; }
        public string Keywords { get; set; }
        public string intensity { get; set; }
    }
}