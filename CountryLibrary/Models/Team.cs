using CountryLibrary.Models.Responses;

namespace CountryLibrary.Models
{
    public class Team
    {
        public string Name { get; set; } = string.Empty;

        public IEnumerable<TeamMember> Members { get; set; } = new List<TeamMember>();
    }
}
