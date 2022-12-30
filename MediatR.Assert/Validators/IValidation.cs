namespace MediatR.Assert.Validators
{
    internal interface IValidation
    {
        bool IsValid(string sendNamesEndTo, string handlerNamesEndTo);
    }
}