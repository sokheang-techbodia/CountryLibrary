using CountryLibrary.Models.Requests;
using CountryLibrary.Models.Responses;
using CountryLibrary.Services.Interfaces;
using System.Text.Json;

namespace CountryLibrary.Services
{
    public class CountryService : ICountryService
    {
        private readonly string baseUrl = "https://restcountries.com/v2/";
        private readonly HttpClient _httpClient;

        public CountryService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
        public async Task<IEnumerable<Country>?> GetCountryByArea(AreaInfoRequest areaInfo)
        {
            var response = await _httpClient.GetAsync($"regionalbloc/{areaInfo.Region}");
            if(response.IsSuccessStatusCode)
            {
                var countries = JsonSerializer.Deserialize<IEnumerable<CountryResposeFromRestCountries>>(response.Content.ReadAsStream());
                countries = countries?.Where(c => c.TimeZones.Contains(areaInfo.Timezone));
                return countries?.Select(s => s.ToCountry());
            }
            return null;
        }

        public async Task<Country?> GetCountryByName(string name)
        {
            var response = await _httpClient.GetAsync($"name/{name}");
            if (response.IsSuccessStatusCode)
            {
                var country = JsonSerializer.Deserialize<IEnumerable<CountryResposeFromRestCountries>>(response.Content.ReadAsStream());
                return country?.FirstOrDefault()?.ToCountry();
            }
            return null;
        }
    }
}
