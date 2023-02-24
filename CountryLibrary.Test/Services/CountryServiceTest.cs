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
        [Theory]
        [InlineData("Cambodia")]
        [InlineData("Japan")]
        [InlineData("China")]
        public async Task GetCountryByName_OnSuccess(string countryName)
        {
            //arrange
            var countryService = new CountryService();
            //act
            var country = await countryService.GetCountryByName(countryName);

            //assert
            Assert.NotNull(country);
            Assert.Equal(countryName, country!.Name);
        }

        [Theory]
        [InlineData("KKK")]
        [InlineData("LLLL")]
        [InlineData("")]
        public async Task GetCountryByName_IncorrectName(string countryName)
        {
            //arrange
            var countryService = new CountryService();
            //act
            var country = await countryService.GetCountryByName(countryName);

            //assert
            Assert.Null(country);
        }

        [Theory]
        [InlineData("ASEAN", "UTC+07:00")]
        [InlineData("EU", "UTC+07:00")]
        public async Task GetCountryByAreaOnSuccess(string region, string timezone)
        {
            //arrange
            var countryService = new CountryService();

            //act
            var areaInfo = new AreaInfoRequest(region,timezone);
            var countries = await countryService.GetCountryByArea(areaInfo);

            //assert
            countries.Should().NotBeNull();
            Assert.All(countries!, c => c.TimeZones.Contains(areaInfo.Timezone));
        }

        [Theory]
        [InlineData("asia","7")]
        [InlineData("a", "UTC+07:00")]
        public async Task GetCountryByAreaOnIncorrectArea(string area, string timezone)
        {
            //arrange
            var countryService = new CountryService();

            //act
            var areaInfo = new AreaInfoRequest(area, timezone);
            var countries = await countryService.GetCountryByArea(areaInfo);

            //assert
            countries.Should().BeNull();
        }
    }
}
