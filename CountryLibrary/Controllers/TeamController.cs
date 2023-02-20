using CountryLibrary.Models.Responses;
using CountryLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CountryLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamServices _teamService;
        public TeamController(ITeamServices teamServices)
        {
            _teamService= teamServices;
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<TeamMember>> GetTeamMembers()
        {
            var members = _teamService.GetTeamMembers();
            return Ok(members);
        }
    }
}
