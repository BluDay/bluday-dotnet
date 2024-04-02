﻿namespace BluDay.Net.CommandLine;

public class ArgumentsParser<TArguments> where TArguments : new()
{
    private readonly PositionalArgument? _positionalArgument;

    private readonly IImmutableList<OptionalArgument> _optionalArguments;

    public PositionalArgument? PositionalArgument
    {
        get => _positionalArgument;
    }

    public IImmutableList<OptionalArgument> OptionalArguments
    {
        get => _optionalArguments;
    }

    public ArgumentsParser() : this(null!, null!) { }

    public ArgumentsParser(PositionalArgument positionalArgument) : this(null!, positionalArgument) { }

    public ArgumentsParser(IEnumerable<OptionalArgument> optionalArguments) : this(optionalArguments, null!) { }

    public ArgumentsParser(IEnumerable<OptionalArgument> optionalArguments, PositionalArgument positionalArgument)
    {
        _positionalArgument = positionalArgument;

        if (optionalArguments is null)
        {
            _optionalArguments = ImmutableList<OptionalArgument>.Empty;

            return;
        }

        _optionalArguments = optionalArguments.Distinct().ToImmutableList();
    }

    public TArguments Parse(params string[] values)
    {
        throw new NotImplementedException();
    }

    public TArguments ParseFromCommandLine()
    {
        return Parse(Environment.GetCommandLineArgs());
    }
}