namespace BluDay.Net.Extensions.DependencyInjection;

public interface IObjectFactoryInfo
{
    // Should I expose the site?
    // IObjectFactorySite Site { get; }

    Type ServiceType { get; }

    Type ImplementationType { get; }
}