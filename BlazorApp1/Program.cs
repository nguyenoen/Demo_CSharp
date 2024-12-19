using BlazorApp1.Components;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


ILogger<Program> logger = WebApplication.CreateBuilder(args).Build().Services.GetRequiredService<ILogger<Program>>();
logger.LogCritical("Message"); // Writes a critical message at log level 5
logger.LogError("Message"); // Writes an error message at log level 4
logger.LogWarning("Message"); // Writes a warning message at log level 3
logger.LogInformation("Message"); // Writes an information message at log level 2
logger.LogDebug("Message"); // Writes a debug message at log level 1
logger.LogTrace("Message"); // Writes a detailed trace message at log level 0
