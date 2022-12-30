using System;
using System.Linq;

namespace MediatR.Assert.Extensions
{
    public static class CommandExtensions
    {
        public static bool TestCommand<TRequest>(this IRequest<TRequest> request)
        {
            throw new NotImplementedException();
        }

        public static bool TestCommandHandler<TIn, TOut>(this IRequestHandler<TIn, TOut> request)
            where TIn : IRequest<TOut>
        {
            throw new NotImplementedException();
        }
    }
}