namespace BluDay.Net.CommandLine;

public class PositionalArgument<TValue> : Argument<TValue>, IPositionalArgument
{
    public string Symbol { get; }

    public PositionalArgument()
    {
        Symbol = Constants.POSITIONAL_ARG_SYMBOL;
    }
}