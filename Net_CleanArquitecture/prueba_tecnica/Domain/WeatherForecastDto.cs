using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WeatherForecastDto
    {
        public int Id { get; set; }
        public int TemperatureC { get; set; }
        public System.DateTime Date { get; set; }
        public string Summary { get; set; }
    }
}
