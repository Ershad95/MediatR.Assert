using System;
using System.ComponentModel;

namespace MediatR.Assert.Extensions
{
    public static class QueryExtensions
    {
        [Description("this method does not Implemented,we Implemented method in new version")]
        public static bool TestQuery<TRequest>(this IRequest<TRequest> request)
        {
            throw new NotImplementedException();
        }
        
        [Description("this method does not Implemented,we Implemented method in new version")]
        public static bool TestQueryHandler<TIn, TOut>(this IRequestHandler<TIn, TOut> request)
            where TIn : IRequest<TOut>
        {
            throw new NotImplementedException();
        }
    }
}