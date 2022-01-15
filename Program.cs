var builder = WebApplication.CreateBuilder(args);

// The configuration delegate, clearly, does not do anything
// Commenting out the call to `ConfigureAppConfiguration` "solves" the issue
builder.WebHost.ConfigureAppConfiguration(
    (ctx, config) => { });

var app = builder.Build();

app.MapGet("/", () => "hello!");

app.Run();
