using Newtonsoft.Json;

namespace Rest.Dtos;

public class SupportDto
{
    [JsonProperty("url")]
    public string Url { get; set; } = null!;

    [JsonProperty("text")]
    public string Text { get; set; } = null!;
}