using LanguageExt.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;
using WebApp.Vo;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> Logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
        }

        [HttpGet]
        public IActionResult Get() 
            
        {
            var team = 
            new Team()
            {
                Members = new []
                {
                    new Name("Shim"),
                    new Name("Park"),
                    new Name("Kim"),
                }
            };

            return Ok(team.Members.Select(x => x.Value));
        }
    }
}
