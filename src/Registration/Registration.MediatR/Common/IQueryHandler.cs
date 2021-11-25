using MediatR;

namespace Registration.MediatR.Common
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
    {

    }
}