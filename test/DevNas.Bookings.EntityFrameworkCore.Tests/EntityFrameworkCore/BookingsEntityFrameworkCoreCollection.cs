using Xunit;

namespace DevNas.Bookings.EntityFrameworkCore;

[CollectionDefinition(BookingsTestConsts.CollectionDefinitionName)]
public class BookingsEntityFrameworkCoreCollection : ICollectionFixture<BookingsEntityFrameworkCoreFixture>
{

}
