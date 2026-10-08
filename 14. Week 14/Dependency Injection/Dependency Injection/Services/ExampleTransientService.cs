using ConsoleDI.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI.Example.Services
{
    internal sealed class ExampleTransientService : IExampleTransientService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
