using Microsoft.AspNetCore.Builder;
using DevNas.Bookings;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("DevNas.Bookings.Web.csproj"); 
await builder.RunAbpModuleAsync<BookingsWebTestModule>(applicationName: "DevNas.Bookings.Web");

public partial class Program
{
}
