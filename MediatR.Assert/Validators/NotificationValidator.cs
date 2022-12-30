using System;
using System.Linq;

namespace MediatR.Assert
{
    public class NotificationValidator : IValidation
    {
        public bool IsValid(string notificationNamesEndTo="Notification", string notificationHandlerNamesEndTo="NotificationHandler")
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var notificationTypeInfo = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(notificationNamesEndTo.ToLower()) &&
                typeInfo.ImplementedInterfaces.Any(type => type == typeof(INotification))));

            if (!notificationTypeInfo.Any())
                throw new ArgumentException("Can not find any Notification");

            var handlerTypeInfo = assemblies.SelectMany(x => x.DefinedTypes.Where(typeInfo =>
                typeInfo.Name.ToLower().EndsWith(notificationHandlerNamesEndTo.ToLower())));

            if (!handlerTypeInfo.Any())
                throw new ArgumentException("Can not find any NotificationHandler");

            if (handlerTypeInfo.Count() != notificationTypeInfo.Count())
                return false;

            foreach (var typeInfo in notificationTypeInfo)
            {
                var interfaces = handlerTypeInfo.SelectMany(x => x.ImplementedInterfaces);
                if (interfaces.Any(x => x.GenericTypeArguments.All(type => type != typeInfo)))
                    return false;
            }

            return true;
        }
    }
}