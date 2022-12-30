namespace MediatR.Assert
{
    internal interface IValidation
    {
        bool IsValid(string sendNamesEndTo, string handlerNamesEndTo);
    }
}