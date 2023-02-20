using CountryLibrary.Models;
using CountryLibrary.Models.Responses;

namespace CountryLibrary.Data
{
    public class TeamData
    {
        public List<Team> Teams { get; private set; }

        public TeamData()
        {
            Teams = new List<Team>
            {
                new Team
                {
                    Name="Backend Team",
                    Members= new List<TeamMember> 
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
                    }
                }
            };
        }
    }
}
