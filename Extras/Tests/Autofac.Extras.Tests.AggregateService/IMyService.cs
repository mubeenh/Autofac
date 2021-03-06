using System;

namespace Autofac.Extras.Tests.AggregateService
{
    /// <summary>
    /// A sample service interface.
    /// </summary>
    public interface IMyService
    {
        int SomeIntValue { get; }
        string SomeStringValue { get; }
        DateTime SomeDateValue { get; }
        ISomeDependency SomeDependency { get; }
    }
}