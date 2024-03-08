namespace BluDay.Net.CommandLine;

public class ArgParser<TArgs> where TArgs : IArgs, new()
{
    private readonly IReadOnlyDictionary<ArgInfo, PropertyInfo> _argToParsablePropertyMap;

    public IEnumerable<ArgInfo> Args => _argToParsablePropertyMap.Keys;

    public IEnumerable<PropertyInfo> ParsableProperties => _argToParsablePropertyMap.Values;

    public IReadOnlyDictionary<ArgInfo, PropertyInfo> ArgumentToParsablePropertyMap
    {
        get => _argToParsablePropertyMap;
    }

    public ArgParser(IEnumerable<ArgInfo> args)
    {
        _argToParsablePropertyMap = null!;
    }

    public TArgs ParseArgs(string[] args)
    {
        return Activator.CreateInstance<TArgs>();
    }
}