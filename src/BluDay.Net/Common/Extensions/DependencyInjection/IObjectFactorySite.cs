namespace BluDay.Net.Common.Extensions.DependencyInjection;

public interface IObjectFactorySite
{
    IObjectFactoryInfo Info { get; }

    ObjectFactory Factory { get; }
}