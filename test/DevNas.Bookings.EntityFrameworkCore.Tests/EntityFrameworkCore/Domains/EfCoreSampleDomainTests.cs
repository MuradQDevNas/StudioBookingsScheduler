using DevNas.Bookings.Samples;
using Xunit;

namespace DevNas.Bookings.EntityFrameworkCore.Domains;

[Collection(BookingsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookingsEntityFrameworkCoreTestModule>
{

}
