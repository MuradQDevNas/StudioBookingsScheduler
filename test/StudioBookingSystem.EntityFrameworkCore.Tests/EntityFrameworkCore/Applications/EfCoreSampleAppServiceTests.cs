using StudioBookingSystem.Samples;
using Xunit;

namespace StudioBookingSystem.EntityFrameworkCore.Applications;

[Collection(StudioBookingSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudioBookingSystemEntityFrameworkCoreTestModule>
{

}
