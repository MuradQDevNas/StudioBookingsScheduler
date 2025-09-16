using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudioBookingSystem.Data;
using Volo.Abp.DependencyInjection;

namespace StudioBookingSystem.EntityFrameworkCore;

public class EntityFrameworkCoreStudioBookingSystemDbSchemaMigrator
    : IStudioBookingSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudioBookingSystemDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudioBookingSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudioBookingSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
