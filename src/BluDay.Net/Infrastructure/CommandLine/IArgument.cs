namespace BluDay.Net.CommandLine;

public interface IArgument
{
    ArgumentActionType ActionType { get; }

    ArgumentStoreType StoreType { get; }

    bool IsRequired { get; }

    object? Constant { get; }

    object? DefaultValue { get; }

    string? Description { get; }

    string? Name { get; }

    int MaxValueCount { get; }
}