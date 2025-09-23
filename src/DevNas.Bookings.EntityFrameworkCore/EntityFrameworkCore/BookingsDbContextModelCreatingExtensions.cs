using DevNas.Bookings.Bookings;
using DevNas.Bookings.Studios;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DevNas.Bookings.EntityFrameworkCore
{
    public static class BookingsDbContextModelCreatingExtensions
    {
        public static void ConfigureBookings(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            // Studio mapping
            builder.Entity<Studio>(b =>
            {
                b.ToTable("Studios");
                b.ConfigureByConvention();

                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.Property(x => x.Location).HasMaxLength(256);
                b.Property(x => x.Description).HasMaxLength(1024);
            });

            builder.Ignore<TimeRange>(); // prevent EF Core from treating it as entity

            // Booking mapping
            builder.Entity<Booking>(b =>
            {
                b.ToTable("Bookings");
                b.ConfigureByConvention();

                b.Property(x => x.StudioId).IsRequired();
                b.Property(x => x.TeacherId).IsRequired();

                // Value Object mapping for TimeRange
                b.OwnsOne(x => x.TimeRange, tr =>
                {
                    tr.Property(x => x.StartTime).IsRequired().HasColumnName("StartTime");
                    tr.Property(x => x.EndTime).IsRequired().HasColumnName("EndTime");
                });

                b.Property(x => x.Status).IsRequired();
            });

        }
    }
}
