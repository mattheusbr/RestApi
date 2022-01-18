using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
         };

        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("adicao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Adicionar(decimal primeiroNumero, decimal segundoNumero)
        {
            var soma = (primeiroNumero + segundoNumero).ToString();
            return Ok(soma);
        }

        [HttpGet("subtracao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            var soma = (primeiroNumero - segundoNumero).ToString();
            return Ok(soma);
        }

        [HttpGet("divisao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            var soma = (primeiroNumero / segundoNumero).ToString();
            return Ok(soma);
        }

        [HttpGet("multiplicacao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            var soma = (primeiroNumero * segundoNumero).ToString();
            return Ok(soma);
        }

        [HttpGet("media/{primeiroNumero}/{segundoNumero}")]
        public IActionResult MediaValor(decimal primeiroNumero, decimal segundoNumero)
        {
            var soma = ((primeiroNumero + segundoNumero) / 2).ToString();
            return Ok(soma);
        }

        [HttpGet("raiz/{numero}")]
        public IActionResult RaizQuadradaValor(decimal numero)
        {
            var soma = (Math.Sqrt((double)numero)).ToString();
            return Ok(soma);
        }

    }
}