using Microsoft.AspNetCore.Mvc;
using PasswordGeneratorApi.Wordlist;

namespace PasswordGeneratorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        [HttpGet("generate")]
        public IActionResult GeneratePassword()
        {
            try
            {
                return Ok(new
                {
                    password = String.Concat(
                        WordGenerator.GetWord(),
                        WordGenerator.GetSymbol(),
                        WordGenerator.GetWord(),
                        WordGenerator.GetSymbol(),
                        WordGenerator.GetWord(),
                        WordGenerator.GetNumber()
                    )
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error when generating password: {ex.Message}");
            }
        }
    }
}
