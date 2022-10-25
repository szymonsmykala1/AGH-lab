var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration) app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => $"Hello World! xD${configuration.GetSection("MyKey").Value}");

app.Run();
