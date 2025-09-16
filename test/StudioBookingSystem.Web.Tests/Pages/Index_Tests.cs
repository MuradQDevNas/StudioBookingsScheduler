using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace StudioBookingSystem.Pages;

[Collection(StudioBookingSystemTestConsts.CollectionDefinitionName)]
public class Index_Tests : StudioBookingSystemWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
