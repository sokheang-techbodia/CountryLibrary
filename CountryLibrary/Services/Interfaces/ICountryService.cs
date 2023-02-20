using CountryLibrary.Models.Requests;
using CountryLibrary.Models.Responses;

namespace CountryLibrary.Services.Interfaces
{
    public interface ICountryService
    {
        Task<Country?> GetCountryByName(string name);

        Task<IEnumerable<Country>?> GetCountryByArea(AreaInfoRequest areaInfo);
    }
}
