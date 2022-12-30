using ApplicationLayer;
using MediatR;
using MediatR.Assert;
using MediatR.Assert.Extensions;
using Xunit;

namespace Application.UnitTest;

public class MediatR
{
    public MediatR()
    {
        var x = new ErshadCommand();
        x.TestCommand();
        
        var t = new ErshadQuery();
        t.TestQuery();
        
        var n = new ErshadNotification();
        n.TestNotification();
        var nn = new ErshadNotificationHandler();
        
        nn.TestNotificationHandler();
    }
    [Fact]
    public void MediatRCommandsValidator_CheckAllCommands_ValidationShouldBeTrue()
    {
        // Arrange
        var command = new CommandValidator();
        // Act
        var commandsIsValid = command.IsValid();
        // Assert
        Assert.True(commandsIsValid);
    }
    [Fact]
    public void MediatRQueriesValidator_CheckAllQueries_ValidationShouldBeTrue()
    {
        // Arrange
        var queryValidator = new QueryValidator();
        // Act
        var queriesIsValid = queryValidator.IsValid();
        // Assert
        Assert.True(queriesIsValid);
    }
}