using System;

namespace MediatR.Assert.Extensions
{
    public static class QueryExtensions
    {
        public static bool TestQuery<TRequest>(this IRequest<TRequest> request)
        {
            throw new NotImplementedException();
        }

        public static bool TestQueryHandler<TIn, TOut>(this IRequestHandler<TIn, TOut> request)
            where TIn : IRequest<TOut>
        {
            throw new NotImplementedException();
        }
    }
}