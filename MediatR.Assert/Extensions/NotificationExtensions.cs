using System;

namespace MediatR.Assert.Extensions
{
    public static class NotificationExtensions
    {
        public static bool TestNotification(this INotification request)
        {
            throw new NotImplementedException();
        }

        public static bool TestNotificationHandler<TNotification>(this INotificationHandler<TNotification> request)
            where TNotification : INotification
        {
            throw new NotImplementedException();
        }
    }

}