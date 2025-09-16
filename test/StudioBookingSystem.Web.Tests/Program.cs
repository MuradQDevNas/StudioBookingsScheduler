using Microsoft.AspNetCore.Builder;
using StudioBookingSystem;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("StudioBookingSystem.Web.csproj"); 
await builder.RunAbpModuleAsync<StudioBookingSystemWebTestModule>(applicationName: "StudioBookingSystem.Web");

public partial class Program
{
}
