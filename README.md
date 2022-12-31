# MediatR.Assert
### Assert your MediatR configuration in any test framework,develop Creative Codes with Ershad Raoufi

### your can use .IsValid() method for Query/Command/Notification Validation

#### CommandValidator usage : you should create object from CommandValidator for Asser Commands,for example : 
 var validCommandConfiguration = new CommandValidator().IsValid();

#### QueryValidator usage : you should create object from QueryValidator for Asser Queries,for example : 
 var validQueryConfiguration = new QueryValidator().IsValid();

#### NotificationValidator usage : you should create object from NotificationValidator for Asser Notifications,for example : 
 var validNotificationConfiguration = new NotificationValidator().IsValid();
 
 #### customization: 
 #### you can pass the custom name for command/commandHandler:
 #### the default value for commandName and Handler are : "Command" and "CommandHandler"
 var validCommandConfiguration = new CommandValidator().IsValid(commandNamesEndTo : "CD" , commandHandlersEndTo : "CH");

