namespace BluDay.Net.Common.Attributes;

public sealed class ArgumentAttribute : Attribute
{
    public string? TargetName { get; init; }
}