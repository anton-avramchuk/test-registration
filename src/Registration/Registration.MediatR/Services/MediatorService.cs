using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Registration.MediatR.Common;

namespace Registration.MediatR.Services
{
    public class MediatorService: IMediatorService
    {
        private readonly IMediator _mediator;

        public MediatorService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TResponse> SendQuery<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(query, cancellationToken);
        }

        public async Task<TResponse> SendCommand<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(command, cancellationToken);
        }

        public async Task SendCommand(ICommand command, CancellationToken cancellationToken = default)
        {
            await _mediator.Send(command, cancellationToken);
        }
    }
}