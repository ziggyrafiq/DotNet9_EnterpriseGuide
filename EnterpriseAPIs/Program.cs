var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/hello", () => "Hello, .from Ziggy Rafiq using C#13 and .NET 9!");
app.MapPost("/add", (int x, int y) => Results.Json(new { Result = x + y }));
await app.RunAsync();
