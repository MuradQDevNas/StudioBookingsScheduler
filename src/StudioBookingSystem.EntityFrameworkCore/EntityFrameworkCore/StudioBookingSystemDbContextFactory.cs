using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace StudioBookingSystem.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StudioBookingSystemDbContextFactory : IDesignTimeDbContextFactory<StudioBookingSystemDbContext>
{
    public StudioBookingSystemDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        StudioBookingSystemEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<StudioBookingSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new StudioBookingSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../StudioBookingSystem.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
