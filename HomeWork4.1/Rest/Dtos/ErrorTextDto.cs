using Newtonsoft.Json;

namespace Rest.Dtos;
public class ErrorTextDto
{
    [JsonProperty("error")]
    public string? ErrorBody { get; set; }
}