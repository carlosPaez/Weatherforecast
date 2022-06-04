using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.WeatherForecast.Commands
{
    public class DeleteWeatherForecastCommand : IRequest<int>
    {
        public int Id { get; set; }
    }

    public class DeleteWeatherForecastCommandHandler : IRequestHandler<DeleteWeatherForecastCommand, int>
    {
        private readonly IWeatherForecastRepository _repository;

        public DeleteWeatherForecastCommandHandler(IWeatherForecastRepository repository)
        {
           _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public Task<int> Handle(DeleteWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.Delete(request.Id));
        }
    }
}
