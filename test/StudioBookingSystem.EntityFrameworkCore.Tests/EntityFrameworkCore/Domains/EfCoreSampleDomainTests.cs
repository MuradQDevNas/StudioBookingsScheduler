using StudioBookingSystem.Samples;
using Xunit;

namespace StudioBookingSystem.EntityFrameworkCore.Domains;

[Collection(StudioBookingSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudioBookingSystemEntityFrameworkCoreTestModule>
{

}
