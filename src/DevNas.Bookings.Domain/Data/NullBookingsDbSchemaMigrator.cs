using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DevNas.Bookings.Data;

/* This is used if database provider does't define
 * IBookingsDbSchemaMigrator implementation.
 */
public class NullBookingsDbSchemaMigrator : IBookingsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
