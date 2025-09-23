using System.Threading.Tasks;

namespace DevNas.Bookings.Data;

public interface IBookingsDbSchemaMigrator
{
    Task MigrateAsync();
}
