namespace CountryLibrary.Models.Requests
{
    public class AreaInfoRequest
    {
        public AreaInfoRequest(string region, string timeZones)
        {
            Region = region;
            Timezone = timeZones;
        }
        public string Region { get; set; }

        public string Timezone { get; set; }
    }
}
