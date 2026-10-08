using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI.Example.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}