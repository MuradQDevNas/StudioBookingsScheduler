using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DevNas.Bookings.Data;
using Volo.Abp.DependencyInjection;

namespace DevNas.Bookings.EntityFrameworkCore;

public class EntityFrameworkCoreBookingsDbSchemaMigrator
    : IBookingsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookingsDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookingsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookingsDbContext>()
            .Database
            .MigrateAsync();
    }
}
