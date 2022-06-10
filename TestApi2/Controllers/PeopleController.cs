using Microsoft.AspNetCore.Mvc;

namespace TestApi2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {


        private readonly ILogger<PeopleController> _logger;


        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "PeopleController")]
        public People Get()
        {
            _logger.LogInformation("Завелась родная");
            return new People() { Age = 23, Name = "Vanya" } ;
            
        }
    }
}


