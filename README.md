# MediatR.Assert
   
## Project Description
 Assert your MediatR configuration in any test framework like <b>XUnit</b> , <b>NUnit</b> , <b>MsUnit</b> , ... ,develop Creative Codes with Ershad Raoufi
    <br />
    <img src="https://img.shields.io/github/contributors/ershad95/MediatR.Assert?color=yellow&amp;style=plastic">
    <img  src="https://img.shields.io/github/languages/top/ershad95/MediatR.Assert?color=brightgreen">
    <img  src="https://img.shields.io/github/languages/count/ershad95/MediatR.Assert?color=brightgreen">
    <img  src="https://img.shields.io/github/license/ershad95/MediatR.Assert?color=blue">
    <img  src="https://img.shields.io/github/languages/code-size/ershad95/MediatR.Assert?color=brightgreen&amp;style=plastic">
    <img  src="https://img.shields.io/github/last-commit/ershad95/MediatR.Assert?color=orange&amp;style=plastic">
    <img  src="https://img.shields.io/tokei/lines/github/ershad95/MediatR.Assert?color=brightgreen&amp;style=plastic">

## Overview
  

#### CommandValidator usage : you should create object from CommandValidator for Asser Commands,for example : 
<pre> var validCommandConfiguration = new CommandValidator().IsValid();</pre>
 
#### QueryValidator usage : you should create object from QueryValidator for Asser Queries,for example : 
 <pre>var validQueryConfiguration = new QueryValidator().IsValid();</pre>

#### NotificationValidator usage : you should create object from NotificationValidator for Asser Notifications,for example : 
<pre> var validNotificationConfiguration = new NotificationValidator().IsValid();</pre>
 
 ## Customization:
 you can pass the custom name for command/commandHandler:
 ##### the default value for CommandName and Handler are : "Command" and "CommandHandler" but you can custom it by bellow code :
 <pre>var validCommandConfiguration = new CommandValidator()
                                   .IsValid(commandNamesEndTo : "something" , 
                                   commandHandlersEndTo : "something");</pre>
 
   you can pass the custom name for query/queryHandler:
 ##### the default value for QueryName and Handler are : "Query" and "QueryHandler" but you can custom it by bellow code :
 <pre>var validCommandConfiguration = new QueryValidator()
                                  .IsValid(queryNamesEndTo : "something" , 
                                  queryHandlersEndTo : "something");</pre>
 
   you can pass the custom name for notification/notificationHandler:
 ##### the default value for NotificationName and Handler are : "Notification" and "NotificationHandler" but you can custom it by bellow code :
 <pre>
  var validCommandConfiguration = new NotificationValidator()
                                 .IsValid(notificationNamesEndTo : "something" , 
                                 notificationHandlerNamesEndTo : "something");
 </pre>

