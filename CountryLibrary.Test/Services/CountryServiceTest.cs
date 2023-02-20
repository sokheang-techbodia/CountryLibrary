using CountryLibrary.Models.Requests;
using CountryLibrary.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLibrary.Test.Services
{
    public class CountryServiceTest
    {
        [Fact]
        public async Task GetCountryByNameTest()
        {
            //arrange
            var countryService = new CountryService();
            //act
            var countryName = "Cambodia";
            var country = await countryService.GetCountryByName(countryName);

            //assert
            Assert.Equal(countryName, country?.Name);
        }

        [Fact]
        public async Task GetCountryByAreaTest()
        {
            //arrange
            var countryService = new CountryService();

            //act
            var areaInfo = new AreaInfoRequest("Asia", "UTC+07:00");
            var countries =await countryService.GetCountryByArea(areaInfo);

            //assert
            Assert.All(countries!, c => c.TimeZones.Contains(areaInfo.TimeZones));
        }
    }
}
