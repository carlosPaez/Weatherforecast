﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WeatherTypeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? IconUrl { get; set; }
    }
}
