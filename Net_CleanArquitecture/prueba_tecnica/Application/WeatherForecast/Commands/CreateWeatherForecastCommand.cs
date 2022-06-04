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
    public class CreateWeatherForecastCommand : IRequest<int>
    {
        public WeatherForecastDto WeatherForecast { get; set; }

    }

    public class CreateWeatherForecastCommandHandler : IRequestHandler<CreateWeatherForecastCommand, int>
    {
        private readonly IWeatherForecastRepository _repository;    

        public CreateWeatherForecastCommandHandler(IWeatherForecastRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        public Task<int> Handle(CreateWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            //TODO: GENERAR MAPPER Y EVITAR EL ENVIO DEL ID, PARA NO TENER INCONVENIENTE DE LLAVE.
            return Task.FromResult(_repository.Create(request.WeatherForecast));
        }
    }
}
