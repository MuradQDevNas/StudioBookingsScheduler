using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DevNas.Bookings.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookingsDbContextFactory : IDesignTimeDbContextFactory<BookingsDbContext>
{
    public BookingsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        BookingsEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<BookingsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new BookingsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DevNas.Bookings.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
