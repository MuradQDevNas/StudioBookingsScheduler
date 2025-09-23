using DevNas.Bookings.Samples;
using Xunit;

namespace DevNas.Bookings.EntityFrameworkCore.Applications;

[Collection(BookingsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookingsEntityFrameworkCoreTestModule>
{

}
