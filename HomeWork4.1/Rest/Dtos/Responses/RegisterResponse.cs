using Newtonsoft.Json;

namespace Rest.Dtos.Responses;
public class RegisterResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("token")]
    public string? Token { get; set; }
}