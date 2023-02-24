using CountryLibrary.Models.Requests;
using CountryLibrary.Models.Responses;
using CountryLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost()]
        public IActionResult GetCountryByName(string name)
        {
            var country = _countryService.GetCountryByName(name);
            return Ok(country);
        }

        [HttpPost()]
        public IActionResult GetCountryByArea([FromBody] AreaInfoRequest areaInfo) 
        {
            var countries = _countryService.GetCountryByArea(areaInfo);
            return Ok(countries);
        }
    }
}
