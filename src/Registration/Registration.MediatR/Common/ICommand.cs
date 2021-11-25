using MediatR;

namespace Registration.MediatR.Common
{
    public interface ICommand<out T> : IRequest<T>
    {

    }

    public interface ICommand : ICommand<object>
    {

    }
}