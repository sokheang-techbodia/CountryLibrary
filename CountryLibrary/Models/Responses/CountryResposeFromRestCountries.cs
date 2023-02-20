using System.Text.Json.Serialization;

namespace CountryLibrary.Models.Responses
{
    public class CountryResposeFromRestCountries
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("alpha2Code")]
        public string Alpha2Code { get; set; } = string.Empty;

        [JsonPropertyName("capital")]
        public string Capital { get; set; } = string.Empty;

        [JsonPropertyName("callingCodes")]
        public List<string> CallingCode { get; set; } = new List<string>();

        [JsonPropertyName("flag")]
        public string FlagUrls { get; set; } = string.Empty;

        [JsonPropertyName("timezones")]
        public List<string> TimeZones { get; set; } = new List<string>();

        public Country ToCountry() => new()
        {
            Name= Name,
            Alpha2Code= Alpha2Code,
            Capital= Capital,
            CallingCode= int.TryParse(CallingCode.FirstOrDefault(),out int c)?c:0,
            FlagUrl = FlagUrls,
            TimeZones=TimeZones.FirstOrDefault()??string.Empty,
        };
    }
}
