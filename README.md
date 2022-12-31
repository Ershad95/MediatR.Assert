# MediatR.Assert
## Project Description
 Assert your MediatR configuration in any test framework,develop Creative Codes with Ershad Raoufi
 
## Overview
### your can use .IsValid() method for Query/Command/Notification structure Validation

#### CommandValidator usage : you should create object from CommandValidator for Asser Commands,for example : 
[https://gist.github.com/Ershad95/75d3174a953290310113a4dabd1cf39c](https://gist.github.com/Ershad95/75d3174a953290310113a4dabd1cf39c#:~:text=var%20validCommandConfiguration%20%3D%20new%20CommandValidator().IsValid()%3B)

#### QueryValidator usage : you should create object from QueryValidator for Asser Queries,for example : 
 var validQueryConfiguration = new QueryValidator().IsValid();

#### NotificationValidator usage : you should create object from NotificationValidator for Asser Notifications,for example : 
 var validNotificationConfiguration = new NotificationValidator().IsValid();
 
 <hr />
 
 #### customization:
 #### you can pass the custom name for command/commandHandler:
 ###### the default value for CommandName and Handler are : "Command" and "CommandHandler" but you can custom it by bellow code :
 var validCommandConfiguration = new CommandValidator()
                                   .IsValid(commandNamesEndTo : "something" , commandHandlersEndTo : "something");
 
  #### you can pass the custom name for query/queryHandler:
 ###### the default value for QueryName and Handler are : "Query" and "QueryHandler" but you can custom it by bellow code :
 var validCommandConfiguration = new QueryValidator()
                                  .IsValid(queryNamesEndTo : "something" , queryHandlersEndTo : "something");
 
   #### you can pass the custom name for notification/notificationHandler:
 ###### the default value for NotificationName and Handler are : "Notification" and "NotificationHandler" but you can custom it by bellow code :
 var validCommandConfiguration = new NotificationValidator()
                                 .IsValid(notificationNamesEndTo : "something" , notificationHandlerNamesEndTo : "something");

