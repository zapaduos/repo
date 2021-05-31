using API.CORE.DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace API.CORE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordValidationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Password"
        };

        private readonly ILogger<PasswordValidationController> _logger;
        private readonly PasswordValidationBusiness _business;

        public PasswordValidationController(ILogger<PasswordValidationController> logger)
        {
            _logger = logger;
            _business = new PasswordValidationBusiness();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string pass)
        {
            try
            {
                var res = await _business.getPasswordValid(pass == null ? string.Empty : pass);

                return StatusCode(200, res);
            }
            catch (Exception ex)
            {
               return StatusCode(500, ex.Message);
            }
        }
    }
}
