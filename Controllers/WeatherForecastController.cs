using Microsoft.AspNetCore.Mvc;

namespace KubernetesCanaryDeployment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        { }

        [HttpGet]
        public string Get()
        {
            return "Default Server";
        }
    }
}
