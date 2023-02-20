using CountryLibrary.Data;
using CountryLibrary.Models.Responses;
using CountryLibrary.Services.Interfaces;

namespace CountryLibrary.Services
{
    public class TeamServiceLocalData : ITeamServices
    {
        private readonly TeamData _teamData;

        public TeamServiceLocalData()
        {
            _teamData= new TeamData();
        }

        public IEnumerable<TeamMember> GetTeamMembers()
        {
            var teamMembers = _teamData.Teams.First().Members;

            return teamMembers;
        }
    }
}
