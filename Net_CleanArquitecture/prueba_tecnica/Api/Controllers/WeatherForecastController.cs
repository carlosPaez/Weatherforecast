using Application.WeatherForecast.Commands;
using Application.WeatherForecast.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class WeatherForecastController : ApiControllerBase
    {
        [HttpGet("GetAll")]
        public async Task<IEnumerable<WeatherForecastDto>> GetAllWeatherForecast()
        {
            return await Mediator.Send(new GetWeatherForecastsQuery());
        }


        [HttpDelete("Delete/{id}")]
        public async Task<int> DeleteWeatherForecast(int id)
        {
            return await Mediator.Send(new DeleteWeatherForecastCommand() { Id = id });
        }

        [HttpPut("Update")]

        public async Task<int>UpdateWeatherForecast([FromBody] WeatherForecastDto weatherForecast)
        {
            return await Mediator.Send(new UpdateWeatherForecastCommand() { WeatherForecast = weatherForecast });
        }


        [HttpPost("Create")]

        public async Task<int> CreateWeatherForecast([FromBody] WeatherForecastDto weatherForecast)
        {
            return await Mediator.Send(new CreateWeatherForecastCommand() { WeatherForecast = weatherForecast });
        }



    }
}