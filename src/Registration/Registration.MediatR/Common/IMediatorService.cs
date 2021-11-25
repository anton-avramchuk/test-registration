using System.Threading;
using System.Threading.Tasks;

namespace Registration.MediatR.Common
{
    public interface IMediatorService
    {
        Task<TResponse> SendQuery<TResponse>(IQuery<TResponse> query, CancellationToken cancellationToken = default);
        Task<TResponse> SendCommand<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken = default);
        Task SendCommand(ICommand command, CancellationToken cancellationToken = default);
    }
}