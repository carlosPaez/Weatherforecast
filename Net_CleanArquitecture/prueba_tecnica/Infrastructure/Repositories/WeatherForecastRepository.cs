using Application.Common.Interfaces;
using Domain;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly ApplicationDbContext _context;
        public WeatherForecastRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecastDto> GetAll()
        {
            var result = _context.WeatherForecast.ToList();

            return result;
        }

        public int Create(WeatherForecastDto weatherForecast)
        {
            _context.WeatherForecast.Add(weatherForecast);
            return _context.SaveChanges();
        }

        public int Update(WeatherForecastDto weatherForecast)
        {
            _context.WeatherForecast.Update(weatherForecast);
            return _context.SaveChanges();
        }

        public int Delete(int Id)
        {
            var weatherforecast = _context.WeatherForecast.SingleOrDefault(x => x.Id == Id);

            if (weatherforecast != null)
            {
                _context.WeatherForecast.Remove(weatherforecast);

                return _context.SaveChanges();
            }

            return 0;
        }
    }
}
