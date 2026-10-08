using ConsoleDI.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI.Example.Services
{
    internal sealed class ExampleScopedService : IExampleScopedService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
