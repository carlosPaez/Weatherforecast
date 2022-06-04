using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)  { }

        public DbSet<WeatherForecastDto> WeatherForecast { get; set; }
        public DbSet<WeatherTypeDto> WeatherType { get; set; }

    }
}
