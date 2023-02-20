using System.Text.Json.Serialization;

namespace CountryLibrary.Models.Responses
{
    public class Country
    {
        public string Name { get; set; } = string.Empty;

        public string Alpha2Code { get; set; } = string.Empty;

        public string Capital { get; set; } = string.Empty;

        public int CallingCode { get; set; }

        public string FlagUrl { get; set; } = string.Empty;

        public string TimeZones { get; set; } = string.Empty;

    }
}
