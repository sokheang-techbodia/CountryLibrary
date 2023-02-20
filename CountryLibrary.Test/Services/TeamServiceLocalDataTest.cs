using CountryLibrary.Models.Responses;
using CountryLibrary.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLibrary.Test.Services
{
    public class TeamServiceLocalDataTest
    {
        [Fact]
        public void GetTeamMermbersTest()
        {
            //arrange
            var teamService = new TeamServiceLocalData();
            var expect = new List<TeamMember>
            {
                new TeamMember
                {
                    Name="Orng",
                    Address="Phnom Penh",
                    Age=22,
                    Email="orng@techbodia.com",
                    Gender="Male",
                },
                new TeamMember
                {
                    Name="Sokheang",
                    Address="Kandal",
                    Age=26,
                    Email="sokheang@techbodia.com",
                    Gender="Male",
                }
            };

            //act
            var actual = teamService.GetTeamMembers();

            //assert
            actual.Should().BeEquivalentTo(expect);
        }
    }
}
