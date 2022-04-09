using JsonBasedLocalization.Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace JsonBasedLocalization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IStringLocalizer<TestController> _localization;

        public TestController(IStringLocalizer<TestController> localization)
        {
            _localization = localization;
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var welcomeMessage = string.Format(_localization["welcome"], name);
            return Ok(welcomeMessage);
        }

        [HttpPost]
        public IActionResult Get(CreateTestDto dto)
        {
            var welcomeMessage = string.Format(_localization["welcome"], dto.Name);
            return Ok(welcomeMessage);
        }
    }
}