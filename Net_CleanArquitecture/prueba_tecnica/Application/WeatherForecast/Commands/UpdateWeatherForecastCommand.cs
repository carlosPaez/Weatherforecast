using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.WeatherForecast.Commands
{
    public class UpdateWeatherForecastCommand : IRequest<int>
    {
        public WeatherForecastDto WeatherForecast { get; set; }
    }

    public class UpdateWeatherForecastCommandHandler : IRequestHandler<UpdateWeatherForecastCommand, int>
    {
        private readonly IWeatherForecastRepository _repository;

        public UpdateWeatherForecastCommandHandler(IWeatherForecastRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        public Task<int> Handle(UpdateWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.Update(request.WeatherForecast));
        }
    }
}
