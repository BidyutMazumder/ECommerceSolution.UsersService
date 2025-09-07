using ECommerce.Core;
using ECommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureServices();
builder.Services.AddCore();
builder.Services.AddControllers();
var app = builder.Build();

//routing
app.UseRouting();

//Auth
app.UseAuthentication();
app.UseAuthorization();

//controller routes
app.MapControllers();
app.Run();
