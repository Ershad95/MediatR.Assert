using System;
using System.Linq;

namespace MediatR.Assert.Validators
{
    public class QueryValidator:IValidation
    {
        public bool IsValid(string queryNamesEndTo = "Query", string queryHandlersEndTo = "QueryHandler")
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var queryTypeInfos = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(queryNamesEndTo.ToLower()) &&
                typeInfo.ImplementedInterfaces.Any(type => type == typeof(IBaseRequest))));

            if (!queryTypeInfos.Any())
                throw new ArgumentException("Can not find any Query");
            
            var handlerTypeInfo = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(queryHandlersEndTo.ToLower())));
            
            if (!handlerTypeInfo.Any())
                throw new ArgumentException("Can not find any QueryHandler");
            
            if (handlerTypeInfo.Count() != queryTypeInfos.Count())
                return false;

            foreach (var typeInfo in queryTypeInfos)
            {
                var interfaces = handlerTypeInfo.SelectMany(x => x.ImplementedInterfaces);
                if (interfaces.Any(x => x.GenericTypeArguments.All(type => type != typeInfo)))
                    return false;
            }

            return true;
        }
    }
}