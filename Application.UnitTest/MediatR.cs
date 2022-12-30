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
       _ = new ErshadCommand();
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
