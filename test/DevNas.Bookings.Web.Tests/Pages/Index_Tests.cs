using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DevNas.Bookings.Pages;

[Collection(BookingsTestConsts.CollectionDefinitionName)]
public class Index_Tests : BookingsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
