using clean_architecture.Contract;
using clean_architecture.Core.Entity;
using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured.Brokers;
using clean_architecture.infastrcured.Factorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared;
using System.Reflection;

namespace clean_architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        ICarServices _carServices;
        private readonly MainBroker _mainBroker;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IExternalService _ExternalService;
        private readonly IConfiguration _Configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MainBroker mainBroker, IExternalService ExternalService, IConfiguration Configuration)
        {
            _logger = logger;
            _mainBroker = mainBroker;
            _ExternalService = ExternalService;
            _Configuration = Configuration;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost("v1/AddCar")]
        public async Task<ActionResult<CarsContract>> Createnew([FromBody] CarsContractOpertions car)
        {
            var oDate = new Car
            {
                CarName = car.CarName,
            };
            await _carServices.Create(oDate);
            return Ok(oDate);
        }


        [HttpGet("v1/Factory")]
        public IActionResult FactoryBuilder()
        {
            var dbContext = DBContextFactory.ContextBuilder("sql");
            dbContext.GetDbContextByType();
            return Ok(dbContext);
        }


        [HttpPost("v1/Broker")]
        public IActionResult Broker(string Url, string content)
        {
            var get = _mainBroker.Get(Url);
            var Post = _mainBroker.Post(Url, content);
            var Put = _mainBroker.Put(Url, content);
            var dlete = _mainBroker.Delete(Url, content);

            List<string> strings = new List<string>() { get, Post, Put, dlete };
            return Ok(strings.Select(x => x));
        }

        [HttpPost("v1/Externalservice")]
        public async Task<IActionResult> Externalservice([FromBody] MobileModel MobileObject)
        {
            // For Test
            //https://api.restful-api.dev/objects
            _Configuration.GetValue<string>("ExternalAPiUrl");
            var oresult = await _ExternalService.Post<MobileModel, MobileModel>(_Configuration["ExternalAPiUrl"], MobileObject);

            return Ok(oresult);
        }


    }
}
