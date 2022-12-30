using System;
using System.ComponentModel;

namespace MediatR.Assert.Extensions
{
    public static class NotificationExtensions
    {
        [Description("this method does not Implemented,we Implemented method in new version")]

        public static bool TestNotification(this INotification request)
        {
            throw new NotImplementedException();
        }
        [Description("this method does not Implemented,we Implemented method in new version")]

        public static bool TestNotificationHandler<TNotification>(this INotificationHandler<TNotification> request)
            where TNotification : INotification
        {
            throw new NotImplementedException();
        }
    }

}