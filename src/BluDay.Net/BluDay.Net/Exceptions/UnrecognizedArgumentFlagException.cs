namespace BluDay.Net.Exceptions;

public sealed class UnrecognizedArgumentFlagException : Exception
{
    public UnrecognizedArgumentFlagException(string value)
        : base(string.Format(ExceptionMessages.UNRECOGNIZED_ARGUMENT_FLAG, value)) { }
}