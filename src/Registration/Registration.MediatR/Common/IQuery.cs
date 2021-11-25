using MediatR;

namespace Registration.MediatR.Common
{
    public interface IQuery<out T> : IRequest<T>
    {

    }
}