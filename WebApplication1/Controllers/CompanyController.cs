using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //[Route("api/[company]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
    [HttpGet]
        [Route("api/company")]
        public IActionResult GetCompany()
        {
            var company = new
            {
                Id = 1,
                Name = "My Company",
                Address = "123 Main St",
                City = "Anytown",
            };
            return Ok(company);
        }
}
