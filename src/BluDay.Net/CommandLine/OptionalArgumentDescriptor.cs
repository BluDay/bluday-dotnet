namespace BluDay.Net.CommandLine;

public sealed class OptionalArgumentDescriptor : ArgumentDescriptor
{
    private readonly ArgumentFlag? _longFlag;

    private readonly ArgumentFlag? _shortFlag;

    public ArgumentFlag PrimaryFlag => (_shortFlag ?? _longFlag)!.Value;

    public ArgumentFlag? LongFlag => _longFlag;

    public ArgumentFlag? ShortFlag => _shortFlag;

    public OptionalArgumentDescriptor(string flagDescriptor)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(flagDescriptor);

        string[] flags = flagDescriptor.Split(Constants.VERTICAL_BAR_CHAR);

        string primary = flags[0];

        if (!primary.IsAlphanumeric())
        {
            throw new ArgumentException();
        }

        string? secondary = flags.ElementAt(1);

        if (secondary is not null)
        {
            if (!secondary.IsAlphanumeric())
            {
                throw new ArgumentException();
            }

            if (primary.Length > secondary.Length)
            {
                throw new ArgumentException();
            }

            _longFlag = new(primary, ArgumentFlagType.Long);

            _shortFlag = new(secondary, ArgumentFlagType.Short);

            return;
        }

        if (primary.Length > 1)
        {
            _longFlag = new(primary, ArgumentFlagType.Long);
        }
        else
        {
            _shortFlag = new(primary, ArgumentFlagType.Short);
        }
    }
}