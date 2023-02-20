namespace CountryLibrary.Models.Requests
{
    public class AreaInfoRequest
    {
        public AreaInfoRequest(string region, string timeZones)
        {
            Region = region;
            TimeZones = timeZones;
        }
        public string Region { get; set; }

        public string TimeZones { get; set; }
    }
}
