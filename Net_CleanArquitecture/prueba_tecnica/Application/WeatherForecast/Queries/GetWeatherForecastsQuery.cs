using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.WeatherForecast.Queries
{
    public class GetWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecastDto>>
    {
       
    }

    public class GetWeatherForecastsQueryHandler : IRequestHandler<GetWeatherForecastsQuery, IEnumerable<WeatherForecastDto>>
    {
        private readonly IWeatherForecastRepository _repository;

        public GetWeatherForecastsQueryHandler(IWeatherForecastRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task<IEnumerable<WeatherForecastDto>> Handle(GetWeatherForecastsQuery request, CancellationToken cancellationToken)
        {
            _repository.Delete(7);

            return Task.FromResult(_repository.GetAll());
        }
    }
}
