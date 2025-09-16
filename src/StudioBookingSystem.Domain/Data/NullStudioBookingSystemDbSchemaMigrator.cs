using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudioBookingSystem.Data;

/* This is used if database provider does't define
 * IStudioBookingSystemDbSchemaMigrator implementation.
 */
public class NullStudioBookingSystemDbSchemaMigrator : IStudioBookingSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
