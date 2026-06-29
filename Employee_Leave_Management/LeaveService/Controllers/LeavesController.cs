using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public LeavesController(IHttpClientFactory httpClientFactory) {
        
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> GetLeaves()
        {
            var employees = await _httpClient.GetStringAsync("https://localhost:7277/api/employees");

            return Ok(new
            {
                Message = "Leave Retrived Successfully",
                EmployeesData = employees
            });
        }

    }
}
