using System;
using System.Linq;
using System.Reflection;
using System.Transactions;

namespace MediatR.Assert
{
    public class CommandValidator : IValidation
    {
        public bool IsValid(string commandNamesEndTo = "Command", string commandHandlersEndTo = "CommandHandler")
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var commandTypeInfos = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(commandNamesEndTo.ToLower()) &&
                typeInfo.ImplementedInterfaces.Any(type => type == typeof(IBaseRequest))));

            var memberInfos = commandTypeInfos as TypeInfo[] ?? commandTypeInfos.ToArray();
            if (!memberInfos.Any())
                throw new ArgumentException("Can not find any Command");

            var handlerTypeInfo = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(commandHandlersEndTo.ToLower())));

            var typeInfos = handlerTypeInfo as TypeInfo[] ?? handlerTypeInfo.ToArray();
            if (!typeInfos.Any())
                throw new ArgumentException("Can not find any CommandHandler");

            if (typeInfos.Count() != memberInfos.Count())
                return false;

            return !(from typeInfo in memberInfos
                let interfaces = typeInfos.SelectMany(x => x.ImplementedInterfaces)
                where interfaces.Any(x => x.GenericTypeArguments.All(type => type != typeInfo))
                select typeInfo).Any();
        }
    }
}