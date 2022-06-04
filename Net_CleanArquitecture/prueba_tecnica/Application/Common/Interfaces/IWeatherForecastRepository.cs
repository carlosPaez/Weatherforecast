using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IWeatherForecastRepository
    {
        int Create(WeatherForecastDto weatherForecast);
        int Update(WeatherForecastDto weatherForecast);

        int Delete(int Id);

        IEnumerable<WeatherForecastDto> GetAll();
    }
}
