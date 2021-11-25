using MediatR;

namespace Registration.MediatR.Common
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {

    }

    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, object> where TCommand : ICommand
    {

    }
}