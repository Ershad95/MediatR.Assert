// See https://aka.ms/new-console-template for more information

using ApplicationLayer;
using MediatR.Assert;

_=new ErshadCommand();

var commandValidator = new CommandValidator();
var commandState = commandValidator.IsValid();

var queryValidator = new QueryValidator();
var queryState = queryValidator.IsValid();

var notificationValidator = new NotificationValidator();
var notificationState = notificationValidator.IsValid();

Console.WriteLine($"Command State : {commandState}");
Console.WriteLine($"Query State :  {queryState}");
Console.WriteLine($"Notification State :  {notificationState}");

Console.ReadLine();