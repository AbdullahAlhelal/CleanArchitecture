using clean_architecture.Contract;
using clean_architecture.Core.Entity;
using clean_architecture.Core.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace clean_architecture.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        ICarServices _carServices;
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1 , 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)) ,
                TemperatureC = Random.Shared.Next(-20 , 55) ,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
       

        [HttpPost("v1/AddCar")]
        public async Task <ActionResult<CarsContract>> Createnew([FromBody] CarsContractOpertions car)
        {
            var oDate = new Car
            {
                CarName= car.CarName,
            };
            await _carServices.Create(oDate);
            return Ok(oDate);
        }

     
    }
}
