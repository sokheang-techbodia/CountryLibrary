using CountryLibrary.Models.Responses;

namespace CountryLibrary.Services.Interfaces
{
    public interface ITeamServices
    {
        IEnumerable<TeamMember> GetTeamMembers();
    }
}
