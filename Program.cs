var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureAppConfiguration(
    (ctx, config) => { });

var app = builder.Build();

app.MapGet("/", () => "hello!");

app.Run();
