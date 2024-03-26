namespace BluDay.Net.CommandLine;

internal readonly struct ParsedArgumentToken
{
    public bool IsFlag { get; }

    public int Index { get; }

    public string Value { get; }

    public ParsedArgumentToken(string value, int index)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);

        IsFlag = value.IsValidArgFlag();

        Index = index;

        Value = value;
    }
}