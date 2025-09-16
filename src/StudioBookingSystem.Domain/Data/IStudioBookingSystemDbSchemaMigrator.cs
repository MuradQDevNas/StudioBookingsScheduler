using System.Threading.Tasks;

namespace StudioBookingSystem.Data;

public interface IStudioBookingSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
