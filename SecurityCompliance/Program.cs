
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        
        options.Authority = "https://need-auth-server.com-here";
                
        options.TokenValidationParameters.ValidateAudience = false;
    });


builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        options.Authority = "https://login.microsoftonline.com/our-tenant-id";
        options.Audience = "our-api-scope";
    });



var app = builder.Build();


app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/secure", () => "Secure Data")
   .RequireAuthorization();

await app.RunAsync();
