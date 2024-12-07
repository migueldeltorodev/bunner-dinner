using BuberDinner.Api.Middleware;
using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
}

var app = builder.Build();
{
    app.UseMiddleware<ErrorHandlingMiddleware>();
    app.MapControllers();
    app.Run();
}