using System;
using System.ComponentModel;
using System.Linq;

namespace MediatR.Assert.Extensions
{
    public static class CommandExtensions
    {
        /// <summary>
        /// We soon Implemented this
        /// </summary>
        /// <param name="request"></param>
        /// <typeparam name="TRequest"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [Description("this method does not Implemented,we Implemented method in new version")]
        public static bool TestCommand<TRequest>(this IRequest<TRequest> request)
        {
            throw new NotImplementedException();
        }
        [Description("this method does not Implemented,we Implemented method in new version")]

        public static bool TestCommandHandler<TIn, TOut>(this IRequestHandler<TIn, TOut> request)
            where TIn : IRequest<TOut>
        {
            throw new NotImplementedException();
        }
    }
}