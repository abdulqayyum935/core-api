using Microsoft.AspNetCore.Mvc;

namespace api_db.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillsController:ControllerBase
    {
        [HttpGet("all")]
        public IActionResult GetAllSkills(){
            return NotFound();
        }
    }
}